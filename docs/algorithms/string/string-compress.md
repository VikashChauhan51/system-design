---
outline: deep
---

# String Compress

Compressed string representation of the input character array.

Example 1
Input: `['a', 'a', 'b', 'b', 'c', 'c', 'c']` Output: `"a2b2c3"`

Example 2
Input: `['a']` Output: `"a"`

Example 3
Input: `['a', 'b', 'b', 'b', 'c']` Output: `"ab3c"`

## Solution

```C#
public class Solution
{
    public string Compress(char[] chars)
    {

        var sb = new StringBuilder();
        int count = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            count++;
            if (i + 1 >= chars.Length || chars[i] != chars[i + 1])
            {
                sb.Append(chars[i]);
                if (count > 1)
                {
                    sb.Append(count);

                }
                count = 0;

            }

        }
        return sb.ToString();

    }
}
```
