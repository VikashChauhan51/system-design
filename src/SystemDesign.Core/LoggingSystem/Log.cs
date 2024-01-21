

namespace SystemDesign.Core.LoggingSystem;


public static class Log
{
    private static readonly ICustomLogger logger = new NullLogger();

    private static ICustomLogger? _logger = null;

    public static ICustomLogger Logger
    {
        get
        {
            return _logger ?? logger;
        }
        set
        {
            _logger = value ?? throw new ArgumentNullException(nameof(Logger));
        }
    }

    public static void Flush()
    {
        _logger = null;
    }
}


