---
outline: deep
---

# Fibonacci

The Fibonacci sequence is a series of numbers `n` in which each number (after the first two) is the sum of the two preceding ones. The sequence typically starts with 0 and 1, although it can start with any two numbers.


## Solution

```C#
public class Solution
{
    public int Fibonacci(int n)
    {
        if (n < 2)
        {
            return n;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
```
