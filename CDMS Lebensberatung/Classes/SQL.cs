using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CDMS_Lebensberatung.cs;

public class SQL
{
    private readonly SqlConnection _connection;
    private readonly string _connectionString;

    /// <summary>
    /// Initializes a new instance of the SQL class with the specified connection string.
    /// </summary>
    /// <param name="connectionString">The connection string to the database.</param>
    public SQL(string connectionString)
    {
        _connectionString = connectionString;
        _connection = new SqlConnection(_connectionString);
    }

    /// <summary>
    /// Opens the database connection.
    /// </summary>
    public void Connect()
    {
        _connection.Open();
    }

    /// <summary>
    /// Closes the database connection.
    /// </summary>
    public void Disconnect()
    {
        _connection.Close();
    }

    /// <summary>
    /// Inserts a dictionary of string values into the specified table.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <param name="data">The dictionary containing the column names and values.</param>
    /// <exception cref="ArgumentException">Thrown when the dictionary is empty.</exception>
    public void InsertStringDict(string tableName, Dictionary<string, string> data)
    {
        if (data.Count == 0)
            throw new ArgumentException("Dictionary enthält keine Einträge", nameof(data));

        var columns = string.Join(",", data.Keys.Select(key => $"[{key}]"));
        var values = string.Join(",", data.Values.Select(value => $"'{value}'"));

        var command = new SqlCommand(
            $"INSERT INTO [dbo].[{tableName}] ({columns}) VALUES ({values})",
            _connection
        );
        command.ExecuteNonQuery();
    }

    /// <summary>
    /// Gets the number of rows in the specified table.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <returns>The number of rows in the table.</returns>
    public int GetNumberOfRows(string tableName)
    {
        using var command = new SqlCommand($"SELECT COUNT(*) FROM [{tableName}]", _connection);
        var count = (int)command.ExecuteScalar();
        return count;
    }

    /// <summary>
    /// Retrieves the full table from the database.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <returns>A DataTable containing the full table data.</returns>
    public DataTable GetFullTable(string tableName)
    {
        var dataTable = new DataTable();

        using var command = new SqlCommand($"SELECT * FROM [{tableName}]", _connection);
        using var adapter = new SqlDataAdapter(command);
        adapter.Fill(dataTable);
        return dataTable;
    }

    /// <summary>
    /// Retrieves a specific column from the specified table.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <param name="columnName">The name of the column.</param>
    /// <returns>A DataTable containing the column data.</returns>
    public DataTable GetColumn(string tableName, string columnName)
    {
        var columnTable = new DataTable();

        using var command = new SqlCommand(
            $"SELECT [{columnName}] FROM [{tableName}]",
            _connection
        );
        using var adapter = new SqlDataAdapter(command);
        adapter.Fill(columnTable);
        return columnTable;
    }

    /// <summary>
    /// Executes a custom query and retrieves the result as a DataTable.
    /// </summary>
    /// <param name="query">The custom query to execute.</param>
    /// <returns>A DataTable containing the query result.</returns>
    public DataTable SendQuery(string query)
    {
        var dataTable = new DataTable();

        using var command = new SqlCommand(query, _connection);
        using var adapter = new SqlDataAdapter(command);
        adapter.Fill(dataTable);
        return dataTable;
    }

    /// <summary>
    /// Retrieves filtered data from the specified table based on the provided filters.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <param name="filters">The dictionary containing the column names and filter values.</param>
    /// <returns>A DataTable containing the filtered data.</returns>
    public DataTable GetDataFiltered(string tableName, Dictionary<string, string> filters)
    {
        var dataTable = new DataTable();
        var required = new StringBuilder();

        foreach (var kvp in filters)
            required.Append($"[{kvp.Key}] LIKE '%{kvp.Value}%' AND ");

        required.Length -= 5;
        using var command = new SqlCommand(
            $"SELECT * FROM [dbo].[{tableName}] WHERE {required}",
            _connection
        );
        using var reader = command.ExecuteReader();
        dataTable.Load(reader);
        return dataTable;
    }

    /// <summary>
    /// Retrieves strictly filtered data from the specified table based on the provided filters.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <param name="filters">The dictionary containing the column names and filter values.</param>
    /// <returns>A DataTable containing the filtered data.</returns>
    public DataTable GetStrictlyFiltered(string tableName, Dictionary<string, string[]> filters)
    {
        var dataTable = new DataTable();
        var required = new StringBuilder();

        foreach (var kvp in filters)
        {
            var filterValues = string.Join(" OR ", kvp.Value.Select(value => $"[{kvp.Key}] = '{value}'"));
            required.Append($"({filterValues}) AND ");
        }

        required.Length -= 5;
        using var command = new SqlCommand(
            $"SELECT * FROM [dbo].[{tableName}] WHERE {required}",
            _connection
        );
        using var reader = command.ExecuteReader();
        dataTable.Load(reader);
        return dataTable;
    }

    /// <summary>
    /// Deletes data from the specified table based on the provided ID.
    /// </summary>
    /// <param name="tableName">The name of the table.</param>
    /// <param name="id">The ID of the data to delete.</param>
    /// <returns>True if the data was successfully deleted, otherwise false.</returns>
    public bool DeleteData(string tableName, string id)
    {
        using var command = new SqlCommand(
            $"DELETE FROM [dbo].[{tableName}] WHERE ID = {id}", _connection);
        command.ExecuteNonQuery();

        return true;
    }
}
