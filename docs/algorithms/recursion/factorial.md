---
outline: deep
---

# Factorial

The factorial of a non-negative integer `n` is the product of all positive integers less than or equal to `n`. It is denoted by `n!` .


## Solution

```C#
public class Solution
{
    public int Factorial(int n)
    {
        if (n <= 0)
        {
            return n;
        }
        return n * Factorial(n - 1);
    }
}
```
