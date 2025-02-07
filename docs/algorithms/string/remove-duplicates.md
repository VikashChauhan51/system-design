
---
outline: deep
---

# Remove Duplicates

A string `s` is said to be palindrome if it remains the same on reading from both ends.

## Solution

```C#
public class Solution
{
    public string RemoveDuplicates(string s)
    {
        var charSet = new HashSet<char>();
        var result = new StringBuilder();

        foreach (char c in s)
        {
            if (!charSet.Contains(c))
            {
                charSet.Add(c);
                result.Append(c);
            }
        }

        return result.ToString();
    }
}
```


