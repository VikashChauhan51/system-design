
namespace SystemDesign.Core.LoggingSystem;

public class CustomLogger : ICustomLogger
{
    private ILogger _logger;

    public CustomLogger(ILogger logger)
    {
        _logger = logger;
    }

    public void LogInformation(string message)
    {
        _logger.LogInfo($"[INFO][{DateTime.Now}]{message}");
    }

    public void LogWarning(string message)
    {
        _logger.LogWarning($"[WARNING][{DateTime.Now}]{message}");
    }

    public void LogError(Exception ex)
    {
        _logger.LogWarning($"[ERROR][{DateTime.Now}]{ex.Message}");
    }
}
