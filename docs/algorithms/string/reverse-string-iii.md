---
outline: deep
---

# Reverse String III


Given a string `s`, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.



### Example 1:

- Input:` s = "Let's take LeetCode contest"`
- Output: `"s'teL ekat edoCteeL tsetnoc"`

### Example 2:

- Input: `s = "Mr Ding"`
- Output: `"rM gniD"`


### Constraints:

- `s` contains printable ASCII characters.
- `s` does not contain any leading or trailing spaces.
- There is at least one word in `s`.
- All the words in `s` are separated by a single space.

## Solution

```C#
public class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');
        char[] outputArray = new char[s.Length];
        int start = 0;
        for (int i = 0; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            if (i != 0)
            {
                outputArray[start++] = ' ';
            }

            int left = 0;
            int right = word.Length - 1;
            while (left <= right)
            {
                outputArray[start + left] = word[right];
                outputArray[start + right] = word[left];
                left++;
                right--;
            }
            start += word.Length;
        }
        return new string(outputArray);
    }
}
```

```go
import "strings"
func reverseWords(s string) string {
    words := strings.Split(s, " ")
    outputArray := make([]rune, len(s))
    start := 0
    for i, word := range words {
        if i != 0 {
            outputArray[start] = ' '
            start++
        }

        left, right := 0, len(word)-1
        for left <= right {
            outputArray[start+left] = rune(word[right])
            outputArray[start+right] = rune(word[left])
            left++
            right--
        }
        start += len(word)
    }
    return string(outputArray)
}
```

