# Valid Parentheses

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

- Open brackets must be closed by the same type of brackets.
- Open brackets must be closed in the correct order.
- Every close bracket has a corresponding open bracket of the same type.


### Example 1:

Input: s = "()"

Output: true

### Example 2:

Input: s = "()[]{}"

Output: true

### Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true



### Constraints:

- `s` consists of parentheses only `()[]{}`.


## Solution

```C#
public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> braces = new Stack<char>();
        foreach (char ch in s)
        {

            if (braces.Count == 0)
            {
                braces.Push(ch);
                continue;
            }

            if (ch == ')' && braces.Peek() == '(')
            {
                braces.Pop();
            }
            else if (ch == '}' && braces.Peek() == '{')
            {
                braces.Pop();
            }
            else if (ch == ']' && braces.Peek() == '[')
            {
                braces.Pop();
            }
            else
            {
                braces.Push(ch);
            }

        }

        return braces.Count == 0;
    }
}
```
