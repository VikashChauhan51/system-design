# Fixed Window RateLimiter

It will restrict the number of requests a client can make within a certain time window. It uses a dictionary to track the number of requests each client has made and when their window started. When a request comes in, it checks if the client’s window has expired. If it has, it starts a new window. If it hasn’t, it increments the client’s request count. If the count exceeds the limit, the request is denied. Otherwise, it’s allowed. This helps prevent any single client from overusing resources.


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