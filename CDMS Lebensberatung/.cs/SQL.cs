using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CDMS_Lebensberatung.cs;

public class SQL
{
    private SqlConnection _connection;
    private readonly string _connectionString = "Data Source=\"localhost\\SQLEXPRESS01\"; Initial Catalog=active_db; Integrated Security=True; TrustServerCertificate=True";

    public SQL(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void Connect()
    {
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
    }

    public void Disconnect()
    {
        _connection.Close();
    }

    public void InsertStringDict(string tableName, Dictionary<string, string> data)
    {
        if (data.Count == 0)
            throw new ArgumentException("Dictionary enthält keine Einträge", nameof(data));

        var columns = "";
        var values = "";

        foreach (var item in data)
        {
            columns += $"[{item.Key}],";
            values += $"'{item.Value}',";
        }

        columns = columns.Remove(columns.Length - 1);
        values = values.Remove(values.Length - 1);

        var command = new SqlCommand(
            $"INSERT INTO [dbo].[{tableName}] ({columns}) VALUES ({values})",
            _connection
        );
        command.ExecuteNonQuery();
    }

    public int GetNumberOfRows(string tableName)
    {
        using var command = new SqlCommand($"SELECT * FROM [{tableName}]", _connection);
        var count = command.ExecuteNonQuery();
        if (count < 1) count = 0;
        return count;
    }

    public DataTable GetFullTable(string tableName)
    {
        var dataTable = new DataTable();

        using var command = new SqlCommand($"SELECT * FROM [{tableName}]", _connection);
        using var adapter = new SqlDataAdapter(command);
        adapter.Fill(dataTable);
        return dataTable;
    }

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

    public DataTable SendQuery(string query)
    {
        var dataTable = new DataTable();

        using var command = new SqlCommand(query, _connection);
        using var adapter = new SqlDataAdapter(command);
        adapter.Fill(dataTable);
        return dataTable;
    }

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

    public bool DeleteData(string tableName, string id)
    {
        using var command = new SqlCommand(
            $"DELETE FROM [dbo].[{tableName}] WHERE ID = {id}", _connection );
        using var reader = command.ExecuteReader();

        return true;
    }
}
