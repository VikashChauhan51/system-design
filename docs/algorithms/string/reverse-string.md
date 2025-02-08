---
outline: deep
---

# Reverse String


Write a function that reverses a string. The input string is given as an array of characters `s`.

You must do this by modifying the input array in-place with `O(1)` extra memory.



### Example 1:

Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]

### Example 2:

Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]


### Constraints:

- `s[i]` is a printable ascii character.

## Solution

```C#
public class Solution
{
    public void ReverseString(char[] s)
    {

        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            left++;
            right--;
        }

    }
}
```

```go
func reverseString(s []byte) {
	total := len(s)
	for i := 0; i < total/2; i = i + 1 {
		temp := s[i]
		s[i] = s[total-i-1]
		s[total-i-1] = temp
	}
}
```

