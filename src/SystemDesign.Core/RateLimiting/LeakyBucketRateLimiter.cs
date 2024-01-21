
namespace SystemDesign.Core.RateLimiting;


public class LeakyBucketRateLimiter
{
    private readonly int capacity;
    private readonly TimeSpan interval;
    private int tokens = 0;
    private DateTime lastRefill = DateTime.UtcNow;
    private readonly object lockObject = new object(); // Dedicated locking object

    public LeakyBucketRateLimiter(int capacity, TimeSpan interval)
    {
        this.capacity = capacity;
        this.interval = interval;
    }

    public bool IsAllowed()
    {
        lock (lockObject) // Lock on the separate object
        {
            RefillTokens();

            if (tokens > 0)
            {
                tokens--;
                return true;
            }

            return false;
        }
    }

    private void RefillTokens()
    {
        TimeSpan elapsed = DateTime.UtcNow - lastRefill;
        int tokensToAdd = (int)Math.Floor(elapsed.TotalSeconds / interval.TotalSeconds);
        tokens = Math.Min(tokens + tokensToAdd, capacity); // Cap at capacity
        lastRefill = lastRefill.AddSeconds(tokensToAdd * interval.TotalSeconds);
    }
}


