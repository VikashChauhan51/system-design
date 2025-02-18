
---
outline: deep
---

# Palindrome

A string `s` is said to be palindrome if it remains the same on reading from both ends.

## Solution

```C#
public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }

        return true;
    }
}
```

```rust
pub struct  Solution{}

impl Solution {

    pub fn is_palindrome(s: &str) -> bool {
    let s = s.chars().collect::<Vec<_>>();
    let len = s.len();

    for i in 0..len / 2 {
        if s[i] != s[len - 1 - i] {
            return false;
        }
    }

    true
}
}
```


