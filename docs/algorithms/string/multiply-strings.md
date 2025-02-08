---
outline: deep
---

# Multiply Strings


Given two non-negative integers `num1` and `num2` represented as strings, return the product of num1 and `num2`, also represented as a string.

Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.



### Example 1:

- Input: `num1 = "2", num2 = "3"`
- Output: `"6"`

### Example 2:

- Input: `num1 = "123", num2 = "456"`
- Output: `"56088"`


### Constraints:

- `num1` and `num2` consist of digits only.
- Both `num1` and `num2` do not contain any leading zero, except the number `0` itself.

## Solution

```C#

public class Solution
{
    public string Multiply(string num1, string num2)
    {

        var result = new int[num1.Length + num2.Length];

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            var num1Digit = num1[i] - '0';
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                var num2Digit = num2[j] - '0';
                var product = num1Digit * num2Digit;
                var sum = product + result[i + j + 1];
                result[i + j + 1] = sum % 10;
                result[i + j] += sum / 10;
            }
        }

        var resultString = new StringBuilder();
        foreach (var digit in result)
        {
            if (!(resultString.Length == 0 && digit == 0))
            {
                resultString.Append(digit);
            }
        }

        return resultString.Length == 0 ? "0" : resultString.ToString();
    }
}

```
