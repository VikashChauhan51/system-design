---
outline: deep
---

# Anagram

An anagram of a string is another string that contains the same characters, only the order of characters can be different.
Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

### Example 1:

- Input: `s = "anagram", t = "nagaram"`
- Output: `true`

### Example 2:

- Input: `s = "rat", t = "car"`
- Output: `false`



### Constraints:

- `s` and `t` consist of lowercase English letters.

## Solution

```C#
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var charCount = new int[256];

        foreach (char c in s)
            charCount[c]++;

        foreach (char c in t)
        {
            if (charCount[c] == 0)
                return false;
            charCount[c]--;
        }

        return true;

    }
}
```

```go
func isAnagram(s string, t string) bool {

	if len(s) != len(t) {
		return false
	}
	var arr [256]rune
	for _, v := range s {
		arr[v] = arr[v] + 1
	}

	for _, v := range t {
		if arr[v] == 0 {
			return false
		}
		arr[v] = arr[v] - 1
	}

	return true

}
```

```rust
pub struct Solution{}

impl Solution {
    pub fn is_anagram(s: String, t: String) -> bool {

        if s.len() != t.len() {
            return false;
        }

        let mut temp_arr = [0u32; 256];
        for ch in s.chars() {
            temp_arr[ch as usize] += 1;
        }

        for ch in t.chars() {
            if temp_arr[ch as usize] == 0 {
                return false;
            }
            temp_arr[ch as usize] -= 1;
        }

        true
    }
}
```

