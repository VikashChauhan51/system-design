---
outline: deep
---

# Sum number Digits

You are given a non-negative integer `n`. Your task is to write an algorithm that sum the digits of `n` and returns the sum value.

Example
Given the input number `1234`, the output should be `10`.

## Solution

```C#
public class Solution
{
    public int SumOfDigits(int n)
    {
        int total = 0;

        while (n != 0)
        {
            int remainder = n % 10;
            total += remainder;
            n /= 10;
        }
        return total;
    }
}
```
