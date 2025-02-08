---
outline: deep
---

# Reverse String II


Given a string `s` and an integer `k`, reverse the first `k` characters for every `2k` characters counting from the start of the string.

If there are fewer than `k` characters left, reverse all of them. If there are less than `2k` but greater than or equal to `k` characters, then reverse the first `k` characters and leave the other as original.



### Example 1:

- Input: `s = "abcdefg", k = 2`
- Output: `"bacdfeg"`

### Example 2:

- Input: `s = "abcd", k = 2`
- Output: `"bacd"`


Constraints:

- `s` consists of only lowercase English letters.

## Solution

```C#
public class Solution
{
    public string ReverseStr(string s, int k)
    {

        var charArray = s.ToCharArray();
        var count = s.Length / (2 * k);
        for (int i = 0; i <= count; i++)
        {
            int left = i * (2 * k);
            int right = Math.Min(left + k-1, s.Length - 1);
            while (left < right)
            {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
        }

        return new string(charArray);
    }
}
```

```go
import "math"
func reverseStr(s string, k int) string {

    charArray := []rune(s)
    count := len(s) / (2 * k)
    for i := 0; i <= count; i++ {
        left := i * (2 * k)
        right := int(math.Min(float64(left+k-1), float64(len(s)-1)))
        for left < right {
            temp := charArray[left]
            charArray[left] = charArray[right]
            charArray[right] = temp
            left++
            right--
        }
    }
    return string(charArray)

}
```

