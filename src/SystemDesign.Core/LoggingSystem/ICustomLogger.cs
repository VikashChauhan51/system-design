

namespace SystemDesign.Core.LoggingSystem;

public interface ICustomLogger
{
    void LogInformation(string message);
    void LogWarning(string message);
    void LogError(Exception ex);
}

