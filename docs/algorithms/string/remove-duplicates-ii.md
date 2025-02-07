
---
outline: deep
---

# Remove All Adjacent Duplicates In String

You are given a string `s` consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.

We repeatedly make duplicate removals on `s` until we no longer can.

Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.



### Example 1:

- Input: `s = "abbaca"`
- Output: `"ca"`
Explanation:
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".

### Example 2:

- Input: `s = "azxxzy"`
- Output: `"ay"`


### Constraints:

- `s` consists of lowercase English letters.

## Solution

```C#
public class Solution
{
    public string RemoveDuplicates(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (stack.Count > 0 && stack.Peek() == c)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }
        var sb = new char[stack.Count];
        for (int i = stack.Count - 1; i >= 0; i--)
        {
            sb[i] = stack.Pop();
        }
        return new string(sb);

    }
}
```


