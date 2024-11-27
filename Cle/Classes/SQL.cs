using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Cle.Classes
{
    public class SQL : IDisposable
    {
        private const string ConnectionString =
            "Data Source=windows10\\SQLEXPRESS; Initial Catalog=active_db; Integrated Security=True; TrustServerCertificate=True";

        private readonly SqlConnection connection;

        public SQL()
        {
            connection = new SqlConnection(ConnectionString);
        }

        public void Connect()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                Console.Error.WriteLine($"Error connecting to database: {ex.Message}");
                throw;
            }
        }

        public void Disconnect()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public bool DeleteData(string tableName, string id)
        {
            var query = $"DELETE FROM [dbo].[{tableName}] WHERE ID = @id";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            return command.ExecuteNonQuery() > 0;
        }

        public DataTable GetColumn(string tableName, string columnName)
        {
            var dataTable = new DataTable();
            var query = $"SELECT [{columnName}] FROM [{tableName}]";

            using var command = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable GetDataFiltered(string tableName, Dictionary<string, string> filters)
        {
            if (filters == null || filters.Count == 0)
            {
                return GetFullTable(tableName);
            }

            var queryBuilder = new StringBuilder($"SELECT * FROM [dbo].[{tableName}] WHERE ");
            var parameters = new List<SqlParameter>();

            foreach (var (key, value) in filters)
            {
                var paramName = $"@{key}";
                queryBuilder.Append($"[{key}] LIKE {paramName} AND ");
                parameters.Add(new SqlParameter(paramName, $"%{value}%"));
            }

            queryBuilder.Length -= 5; // Remove trailing " AND "

            using var command = new SqlCommand(queryBuilder.ToString(), connection);
            command.Parameters.AddRange(parameters.ToArray());

            using var reader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public DataTable GetFullTable(string tableName)
        {
            var dataTable = new DataTable();
            var query = $"SELECT * FROM [{tableName}]";

            using var command = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public int GetNumberOfRows(string tableName)
        {
            var query = $"SELECT COUNT(*) FROM [{tableName}]";

            using var command = new SqlCommand(query, connection);
            return (int)command.ExecuteScalar();
        }

        public DataTable GetStrictlyFiltered(string tableName, Dictionary<string, string[]> filters)
        {
            if (filters == null || filters.Count == 0 || filters.All(kvp => kvp.Value.Length == 0))
            {
                return GetFullTable(tableName);
            }

            var queryBuilder = new StringBuilder($"SELECT * FROM [dbo].[{tableName}] WHERE ");
            var parameters = new List<SqlParameter>();
            int paramIndex = 0;

            foreach (var (key, values) in filters.Where(kvp => kvp.Value.Length > 0))
            {
                var conditions = values.Select(value =>
                {
                    var paramName = $"@p{paramIndex++}";
                    parameters.Add(new SqlParameter(paramName, value));
                    return $"[{key}] = {paramName}";
                });

                queryBuilder.Append($"({string.Join(" OR ", conditions)}) AND ");
            }

            queryBuilder.Length -= 5; // Remove trailing " AND "

            using var command = new SqlCommand(queryBuilder.ToString(), connection);
            command.Parameters.AddRange(parameters.ToArray());

            using var reader = command.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void InsertStringDict(string tableName, Dictionary<string, string> data)
        {
            if (data == null || data.Count == 0)
            {
                throw new ArgumentException("The dictionary cannot be empty.", nameof(data));
            }

            var columns = string.Join(",", data.Keys.Select(key => $"[{key}]"));
            var values = string.Join(",", data.Keys.Select((_, i) => $"@param{i}"));
            var query = $"INSERT INTO [dbo].[{tableName}] ({columns}) VALUES ({values})";

            using var command = new SqlCommand(query, connection);
            foreach (var (key, value) in data.Select((kvp) => (kvp.Key, kvp.Value)))
            {
                command.Parameters.AddWithValue($"@param", value);
            }

            command.ExecuteNonQuery();
        }

        public DataTable SendQuery(string query)
        {
            var dataTable = new DataTable();

            using var command = new SqlCommand(query, connection);
            using var adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
