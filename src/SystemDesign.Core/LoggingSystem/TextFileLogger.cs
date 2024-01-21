

namespace SystemDesign.Core.LoggingSystem;

// Logging Text file facade implementation
public class TextFileLogger : ILogger
{

    private readonly string _filePathInfo;
    private readonly string _filePathWarn;
    private readonly string _filePathError;

    public TextFileLogger(string filePathInfo, string filePathWarn, string filePathError)
    {
        _filePathInfo = filePathInfo;
        _filePathWarn = filePathWarn;
        _filePathError = filePathError;
    }

    public void LogInfo(string message)
    {
        LogToFile(_filePathInfo, $"[Info] {message}");
    }

    public void LogWarning(string message)
    {
        LogToFile(_filePathWarn, $"[Warning] {message}");
    }

    public void LogError(string message)
    {
        LogToFile(_filePathError, $"[Error] {message}");
    }

    private void LogToFile(string path, string logMessage)
    {
        // Write logMessage to the text file
        using (var writer = new StreamWriter(path, true))
        {
            writer.WriteLine(logMessage);
        }
    }
}

