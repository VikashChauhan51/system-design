# Integer to English Words
Convert a non-negative integer `num` to its English words representation.



### Example 1:

Input: num = 123
Output: "One Hundred Twenty Three"

### Example 2:

Input: num = 12345
Output: "Twelve Thousand Three Hundred Forty Five"

### Example 3:

Input: num = 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"


## Solution

```C#
public class Solution
{
    static string[] units = {
            "Zero",        "One",       "Two",      "Three",
            "Four",    "Five",      "Six",      "Seven",
            "Eight",   "Nine",      "Ten",      "Eleven",
            "Twelve",  "Thirteen",  "Fourteen", "Fifteen",
            "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

    static string[] tens = {
            "",     "",     "Twenty",  "Thirty", "Forty",
            "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

    static string[] multiplier =
                {"Hundred", "Thousand", "Million", "Billion"};
    public string NumberToWords(int num)
    {
        if (num < 20)
        {
            return units[num];
        }

        if (num < 100)
        {
            return tens[num / 10] + (num % 10 != 0 ? " " + units[num % 10] : "");
        }

        if (num < 1000)
        {
            return NumberToWords(num / 100) + " " + multiplier[0] + (num % 100 != 0 ? " " + NumberToWords(num % 100) : "");
        }

        if (num < 1000000)
        {
            return NumberToWords(num / 1000) + " " + multiplier[1] + (num % 1000 != 0 ? " " + NumberToWords(num % 1000) : "");
        }

        if (num < 1000000000)
        {
            return NumberToWords(num / 1000000) + " " + multiplier[2] + (num % 1000000 != 0 ? " " + NumberToWords(num % 1000000) : "");
        }

        return NumberToWords(num / 1000000000) + " " + multiplier[3] + (num % 1000000000 != 0 ? " " + NumberToWords(num % 1000000000) : "");
    }
}
```
log n
