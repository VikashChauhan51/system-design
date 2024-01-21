using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace SystemDesign.Core.LoggingSystem;



public class AdoNetDatabaseProvider : IDatabaseProvider
{
    private readonly string _connectionString;
    private SqlConnection _connection;

    public AdoNetDatabaseProvider(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void OpenConnection()
    {
        _connection = new SqlConnection(_connectionString);
        _connection.Open();
    }

    public void Execute(string query)
    {
        using (SqlCommand command = new SqlCommand(query, _connection))
        {
            command.ExecuteNonQuery();
        }
    }

    public void CloseConnection()
    {
        if (_connection != null && _connection.State == ConnectionState.Open)
        {
            _connection.Close();
            _connection.Dispose();
            _connection = null;
        }
    }

    public SqlCommand CreateCommand()
    {
        return _connection.CreateCommand();
    }
}


