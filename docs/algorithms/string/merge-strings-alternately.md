---
outline: deep
---

# Merge Strings Alternately

You are given two strings `word1` and `word2`. Merge the strings by adding letters in alternating order, starting with `word1`. If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.



### Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"

### Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"

### Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"


### Constraints:

- `word1` and `word2` consist of lowercase English letters.

## Solution

```C#
public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int i = 0;
        int j = 0;
        var result = new StringBuilder(word1.Length + word2.Length);

        while (i < word1.Length && j < word2.Length)
        {
            result.Append(word1[i]);
            result.Append(word2[j]);
            i++;
            j++;
        }

        // Add remaning characters of word1 string if any
        for (; i < word1.Length; i++)
        {
            result.Append(word1[i]);
        }

        // Add remaning characters of word12 string if any
        for (; j < word2.Length; j++)
        {
            result.Append(word2[j]);
        }

        return result.ToString();
    }
}
```


```rust
pub struct Solution{}

impl Solution {
    pub fn merge_alternately(word1: String, word2: String) -> String {
        let len1 = word1.len();
        let len2 = word2.len();
        let mut result = String::with_capacity(len1 + len2);
        let mut iter1 = word1.chars();
        let mut iter2 = word2.chars();

        for _ in 0..len1.max(len2) {
            if let Some(c1) = iter1.next() {
                result.push(c1);
            }
            if let Some(c2) = iter2.next() {
                result.push(c2);
            }
        }

        result
    }
}

```
