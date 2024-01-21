
namespace SystemDesign.Core.LoggingSystem;

public class NullLogger : ICustomLogger
{
    public void LogInformation(string message)
    {
        //empty
    }

    public void LogWarning(string message)
    {
        //empty
    }

    public void LogError(Exception ex)
    {
        //empty
    }
}

