# Leaky Bucket RateLimiter


```C#


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

```

It calculates the time passed since the last refill, determines how many tokens to add based on this elapsed time and a set interval, and adds these tokens up to a maximum capacity. The time of the last refill is then updated. This ensures tokens are added at a fixed rate and the total number doesn’t exceed the capacity.
