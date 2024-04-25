# Fixed Window RateLimiter

```C#

public class FixedWindowRateLimiter
{
    private readonly int requestLimit;
    private readonly TimeSpan windowDuration;
    private readonly ConcurrentDictionary<string, (int count, DateTime windowStart)> requestCounts = new ConcurrentDictionary<string, (int count, DateTime windowStart)>();

    public FixedWindowRateLimiter(int requestLimit, TimeSpan windowDuration)
    {
        this.requestLimit = requestLimit;
        this.windowDuration = windowDuration;
    }

    public bool IsAllowed(string clientId)
    {
        lock (requestCounts)
        {
            (int count, DateTime windowStart) = requestCounts.GetOrAdd(clientId, (0, DateTime.UtcNow));

            TimeSpan elapsed = DateTime.UtcNow - windowStart;
            if (elapsed > windowDuration)
            {
                requestCounts[clientId] = (0, DateTime.UtcNow); // Reset count for a new window
                return true;
            }

            if (count < requestLimit)
            {
                requestCounts[clientId] = (Interlocked.Increment(ref count), windowStart); // Incre-ment count
                return true;
            }

            return false; // Request limit reached
        }
    }
}

```