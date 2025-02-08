---
outline: deep
---

# Reverse number

You are given a non-negative integer `n`. Your task is to write an algorithm that reverses the digits of `n` and returns the reversed number.

Example
Given the input number `1234`, the output should be `4321`.

## Solution

```C#
public class Solution
{
    public int Reverse(int n)
    {
        int result = 0;
        while (n != 0)
        {
            int remainder = n % 10;
            result = result * 10 + remainder;
            n /= 10;
        }
        return result;
    }
}
```
