using System.Collections.Concurrent;

namespace SystemDesign.Core.RateLimiting;



public class SlidingWindowRateLimiter
{
    private readonly int requestLimit;
    private readonly TimeSpan windowDuration;
    private readonly ConcurrentQueue<DateTime> requestTimestamps = new ConcurrentQueue<DateTime>();

    public SlidingWindowRateLimiter(int requestLimit, TimeSpan windowDuration)
    {
        this.requestLimit = requestLimit;
        this.windowDuration = windowDuration;
    }

    public bool IsAllowed()
    {
        lock (requestTimestamps)
        {
            // Slide the window and remove expired timestamps
            DateTime threshold = DateTime.UtcNow - windowDuration;
            while (requestTimestamps.Count > 0 && requestTimestamps.TryPeek(out DateTime timeFrame) && timeFrame < threshold)
            {
                requestTimestamps.TryDequeue(out _);
            }

            // Check if the request count within the window is within limits
            return requestTimestamps.Count < requestLimit;
        }
    }

    public void AddRequest()
    {
        lock (requestTimestamps)
        {
            requestTimestamps.Enqueue(DateTime.UtcNow); // Add current timestamp to the window
        }
    }
}


