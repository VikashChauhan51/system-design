

namespace SystemDesign.Core.LoggingSystem;

public class EmailLogger : ILogger
{
    private readonly string _emailRecipient;
    private readonly IEmailProvider _emailProvider;
    public EmailLogger(IEmailProvider emailProvider, string emailRecipient)
    {
        _emailProvider = emailProvider;
        _emailRecipient = emailRecipient;
    }

    public void LogInfo(string message)
    {
        SendEmail("Information log message", "[Information] " + message);
    }

    public void LogWarning(string message)
    {
        SendEmail("Warning log message", "[Warning] " + message);
    }

    public void LogError(string message)
    {
        SendEmail("Error log message", "[Error] " + message);
    }

    private void SendEmail(string title, string emailMessage)
    {
        _emailProvider.Send(new List<string>() { _emailRecipient }, new List<string>(), title, emailMessage);
    }
}

