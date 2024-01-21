

namespace SystemDesign.Core.LoggingSystem;

// Logging Database facade implementation
public class DatabaseLogger : ILogger
{
    private readonly string _informationTableName;
    private readonly string _warningTableName;
    private readonly string _errorTableName;
    private readonly IDatabaseProvider _databaseProvider;

    public DatabaseLogger(IDatabaseProvider databaseProvider, string informationTableName, string warningTableName, string errorTableName)
    {
        databaseProvider = databaseProvider;
        _informationTableName = informationTableName;
        _warningTableName = warningTableName;
        _errorTableName = errorTableName;
    }

    public void LogInfo(string message)
    {
        LogToDatabase(_informationTableName, $"[Info] {message}");
    }

    public void LogWarning(string message)
    {
        LogToDatabase(_warningTableName, $"[Warning] {message}");
    }

    public void LogError(string message)
    {
        LogToDatabase(_errorTableName, $"[Error] {message}");
    }

    private void LogToDatabase(string tableName, string logMessage)
    {
        _databaseProvider.OpenConnection();
        var command = _databaseProvider.CreateCommand();
        command.CommandText = "INSERT INTO " + tableName + " (message) VALUES (@logMessage)";
        command.Parameters.AddWithValue("@logMessage", logMessage);
        command.ExecuteNonQuery();
        _databaseProvider.CloseConnection();
    }

}

