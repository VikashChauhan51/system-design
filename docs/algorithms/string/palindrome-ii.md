
---
outline: deep
---

# Palindrome II

Given a string `s`, return `true` if the `s` can be palindrome after deleting at most one character from it.

### Example 1:

- Input: `s = "aba"`
- Output: `true`

### Example 2:

- Input:` s = "abca"`
- Output: `true`
- Explanation: You could delete the character 'c'.

### Example 3:

- Input: `s = "abc"`
- Output: `false`


### Constraints:

- `s` consists of lowercase English letters.

## Solution

```C#
public class Solution
{
    public bool ValidPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right){
            if (s[left] == s[right]){
                left++;
                right--;
            }
            else
            {
                return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
            }
        }

        return true;
    }

    private bool IsPalindrome(string s, int left, int right)
    {
        while (left < right){
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
```

```go
func validPalindrome(s string) bool {
    left, right := 0, len(s)-1

    for left < right {
        if s[left] == s[right] {
            left++
            right--
        } else {
            return isPalindrome(s, left+1, right) || isPalindrome(s, left, right-1)
        }
    }

    return true
}

func isPalindrome(s string, left, right int) bool {
    for left < right {
        if s[left] != s[right] {
            return false
        }
        left++
        right--
    }
    return true
}
```


