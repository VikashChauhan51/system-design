# Minimum operations to convert given string into all 1s or 0s
Given a string `S` containing `0s` and `1s` of length `N`,the task is to output the minimum operations required to convert `S` into either all `1s` or `0s`.

### Example
Input: N = 4, X = 2, S = "1100"
Output: 2

## Solution

```C#
public class Solution
{
    public  int MinFlips(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        int count0 = 0;
        int count1 = 0;

        if (s[0] == '0')
            count0++;
        else
            count1++;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != s[i - 1])
            {
                if (s[i] == '0')
                    count0++;
                else
                    count1++;
            }
        }

        return Math.Min(count0, count1);
    }
}
```
