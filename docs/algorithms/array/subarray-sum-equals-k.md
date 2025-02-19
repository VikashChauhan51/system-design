# Subarray Sum Equals K

Given an array of integers `nums` and an integer `k`, return the total number of subarrays whose sum equals to `k`.

A subarray is a contiguous non-empty sequence of elements within an array.



### Example 1:

Input: nums = [1,1,1], k = 2
Output: 2

### Example 2:

Input: nums = [1,2,3], k = 3
Output: 2


## Solution

```C#
public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> sumCounts = new Dictionary<int, int>();
        sumCounts[0] = 1;
        int cumulativeSum = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            cumulativeSum += nums[i];

            if (sumCounts.ContainsKey(cumulativeSum - k))
            {
                count += sumCounts[cumulativeSum - k];
            }

            if (sumCounts.ContainsKey(cumulativeSum))
            {
                sumCounts[cumulativeSum]++;
            }
            else
            {
                sumCounts[cumulativeSum] = 1;
            }
        }

        return count;
    }
}

```

