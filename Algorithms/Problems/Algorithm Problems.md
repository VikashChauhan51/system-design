### 43. Isomorphic Strings

Given two strings s and t, determine if they are isomorphic. Two strings are isomorphic if the characters in s can be replaced to get t.

```
Examples:
- s = "egg", t = "add" → true (e→a, g→d)
- s = "badc", t = "baba" → false (a→b, but also a→a conflict)
```

#### 43.1 [HashMap - Character Mapping]

```csharp
public static bool IsIsomorphic_HashMap(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, char> map = new();

    for (int i = 0; i < s.Length; i++)
    {
        char sChar = s[i];
        char tChar = t[i];

        if (map.ContainsKey(sChar))
        {
            if (map[sChar] != tChar)
            {
                return false; // Conflict: s[i] maps to different t char
            }
        }
        else
        {
            map[sChar] = tChar;
        }
    }

    return true;
}
```

```text
s = "egg", t = "add"

i=0: e→a (map: {e→a})
i=1: g→d (map: {e→a, g→d})
i=2: g→d (already mapped, g→d ✓)

Result: true ✓

---

s = "badc", t = "baba"

i=0: b→b (map: {b→b})
i=1: a→a (map: {b→b, a→a})
i=2: d→b (map: {b→b, a→a, d→b})
i=3: c→a (map: {b→b, a→a, d→b, c→a})

No conflicts! But wait...
a maps to 'a' in position 1 and 'a' in position 3 ✓
But d maps to 'b', and b maps to 'b' → 'b' appears in both!

This algorithm only checks one direction (s→t), not reverse!
```

- **Time Complexity:** `O(n)` - single pass
- **Space Complexity:** `O(k)` - where k is size of alphabet (≤256)

#### 43.2 [Bidirectional Mapping]

```csharp
public static bool IsIsomorphic_Bidirectional(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, char> mapStoT = new();
    Dictionary<char, char> mapTtoS = new();

    for (int i = 0; i < s.Length; i++)
    {
        char sChar = s[i];
        char tChar = t[i];

        // Check s → t mapping
        if (mapStoT.ContainsKey(sChar))
        {
            if (mapStoT[sChar] != tChar) return false;
        }
        else
        {
            mapStoT[sChar] = tChar;
        }

        // Check t → s mapping (ensures one-to-one)
        if (mapTtoS.ContainsKey(tChar))
        {
            if (mapTtoS[tChar] != sChar) return false;
        }
        else
        {
            mapTtoS[tChar] = sChar;
        }
    }

    return true;
}
```

- **Time Complexity:** `O(n)`
- **Space Complexity:** `O(k)` - two hash maps

---

### 44. First Unique Character in a String

Given a string s, find the first non-repeating character in it and return its index. If the string does not contain a unique character, return -1.

```
Examples:
- s = "leetcode" → 0 (l)
- s = "loveleetcode" → 2 (v)
- s = "aabb" → -1
```

#### 44.1 [Brute Force - Nested Loop]

```csharp
public static int FirstUniqChar_BruteForce(string s)
{
    // For each character, check if it appears elsewhere
    for (int i = 0; i < s.Length; i++)
    {
        bool isUnique = true;
        for (int j = 0; j < s.Length; j++)
        {
            if (i != j && s[i] == s[j])
            {
                isUnique = false;
                break;
            }
        }

        if (isUnique)
        {
            return i;
        }
    }

    return -1;
}
```

```text
s = "leetcode"

i=0 (l): Check against all → appears once → return 0 ✓

Result: 0
```

- **Time Complexity:** `O(n²)` - nested loops
- **Space Complexity:** `O(1)` - no extra space

#### 44.2 [HashMap - O(n)]

```csharp
public static int FirstUniqChar_HashMap(string s)
{
    // Count frequency of each character
    Dictionary<char, int> freq = new();
    foreach (char c in s)
    {
        if (freq.ContainsKey(c))
            freq[c]++;
        else
            freq[c] = 1;
    }

    // Find first character with frequency 1
    for (int i = 0; i < s.Length; i++)
    {
        if (freq[s[i]] == 1)
        {
            return i;
        }
    }

    return -1;
}
```

```text
s = "leetcode"

Pass 1 - Count:
l:1, e:3, t:1, c:1, o:1, d:1

Pass 2 - Find First with count=1:
i=0: l has count 1 → return 0 ✓

Result: 0
```

- **Time Complexity:** `O(n)` - two passes
- **Space Complexity:** `O(k)` - frequency map of alphabet size

---

### 45. Longest Substring Without Repeating Characters

#### Constraints
- Input string is not null or empty
- Find substring with no repeating characters
- String contains lowercase English letters
- Return length of longest substring

Given a string s, find the length of the longest substring without repeating characters.

```
Examples:
- s = "abcabcbb" → 3 ("abc")
- s = "bbbbb" → 1 ("b")
- s = "pwwkew" → 3 ("wke")
```

#### 45.1 [Brute Force - All Substrings]

```csharp
public static int LengthOfLongestSubstring_BruteForce(string s)
{
    int maxLength = 0;

    // Try all substrings
    for (int i = 0; i < s.Length; i++)
    {
        HashSet<char> seen = new();
        for (int j = i; j < s.Length; j++)
        {
            if (seen.Contains(s[j]))
            {
                break; // Repeating character found
            }

            seen.Add(s[j]);
            maxLength = Math.Max(maxLength, j - i + 1);
        }
    }

    return maxLength;
}
```

```text
s = "abcabcbb"

i=0: a,b,c (max=3), hit 'a' → break
i=1: b,c,a (max=3), hit 'b' → break
i=2: c,a,b (max=3), hit 'c' → break
i=3: a,b,c (max=3), hit 'a' → break
...

Result: 3
```

- **Time Complexity:** `O(n²)` - nested loops
- **Space Complexity:** `O(k)` - HashSet

#### 45.2 [Sliding Window - O(n)]

```csharp
public static int LengthOfLongestSubstring_SlidingWindow(string s)
{
    Dictionary<char, int> charIndex = new();
    int maxLength = 0;
    int left = 0;

    for (int right = 0; right < s.Length; right++)
    {
        char c = s[right];

        // If character already in current window, move left pointer
        if (charIndex.ContainsKey(c) && charIndex[c] >= left)
        {
            left = charIndex[c] + 1;
        }

        charIndex[c] = right;
        maxLength = Math.Max(maxLength, right - left + 1);
    }

    return maxLength;
}
```

```text
s = "abcabcbb"

[a]          left=0, right=0, max=1
[ab]         left=0, right=1, max=2
[abc]        left=0, right=2, max=3
[bca]        left=1, right=3, max=3 (a at 0, move left to 1)
[cab]        left=2, right=4, max=3 (b at 1, move left to 2)
[abc]        left=3, right=5, max=3 (c at 2, move left to 3)
[bc]         left=4, right=6, max=3 (b at 4, move left to 5)
[b]          left=5, right=7, max=3 (b at 5, move left to 6)

Result: 3
```

- **Time Complexity:** `O(n)` - single pass with two pointers
- **Space Complexity:** `O(k)` - HashMap of characters

---

### 46. Reverse Words in a String

#### Constraints
- Input string is not null or empty
- Reverse order of words (maintain word order internally)
- Handle multiple spaces between words
- Trim leading/trailing spaces

Given an input string s, reverse the order of the words. A word is defined as a sequence of non-space characters.

```
Examples:
- s = "the sky is blue" → "blue is sky the"
- s = "  hello world  " → "world hello"
```

#### 46.1 [Split and Reverse]

```csharp
public static string ReverseWords_Split(string s)
{
    // Split on spaces and filter empty strings
    string[] words = s.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

    // Reverse array
    System.Array.Reverse(words);

    // Join back
    return string.Join(" ", words);
}
```

```text
s = "the sky is blue"

Split: ["the", "sky", "is", "blue"]
Reverse: ["blue", "is", "sky", "the"]
Join: "blue is sky the"

Result: "blue is sky the" ✓
```

- **Time Complexity:** `O(n)` - split + reverse + join
- **Space Complexity:** `O(n)` - word array

#### 46.2 [Two-Pointer]

```csharp
public static string ReverseWords_TwoPointer(string s)
{
    char[] chars = s.ToCharArray();
    int n = chars.Length;

    // Step 1: Reverse entire string
    Reverse(chars, 0, n - 1);

    // Step 2: Reverse each word
    int start = 0;
    for (int i = 0; i <= n; i++)
    {
        if (i == n || chars[i] == ' ')
        {
            Reverse(chars, start, i - 1);
            start = i + 1;
        }
    }

    // Step 3: Remove extra spaces
    return CleanSpaces(chars, n);
}

private static void Reverse(char[] chars, int start, int end)
{
    while (start < end)
    {
        char temp = chars[start];
        chars[start] = chars[end];
        chars[end] = temp;
        start++;
        end--;
    }
}

private static string CleanSpaces(char[] chars, int n)
{
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        if (chars[i] != ' ')
        {
            // Add space before word (if not first word)
            if (j != 0) chars[j++] = ' ';
            while (i < n && chars[i] != ' ')
            {
                chars[j++] = chars[i++];
            }
        }
    }
    return new string(chars, 0, j);
}
```

- **Time Complexity:** `O(n)` - multiple single passes
- **Space Complexity:** `O(1)` - in-place (after converting to char array)

---

### 47. Word Break

#### Constraints
- Input string s is not null or empty
- wordDict contains valid dictionary words
- Each word in dict is unique
- Must use all characters in s
- Word can be reused multiple times

Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of dictionary words.

```
Examples:
- s = "leetcode", dict = ["leet","code"] → true
- s = "applepenapple", dict = ["apple","pen"] → true
- s = "catsandog", dict = ["cat","cats","and","sand","dog"] → false
```

#### 47.1 [Recursion with Memoization]

```csharp
public static bool WordBreak_Memoization(string s, IList<string> wordDict)
{
    var memo = new Dictionary<int, bool>();
    var dictSet = new HashSet<string>(wordDict);

    return CanBreak(s, 0, dictSet, memo);
}

private static bool CanBreak(string s, int start, HashSet<string> dict, Dictionary<int, bool> memo)
{
    // Base case
    if (start == s.Length)
    {
        return true;
    }

    // Check memo
    if (memo.ContainsKey(start))
    {
        return memo[start];
    }

    // Try all possible words starting at 'start'
    for (int end = start + 1; end <= s.Length; end++)
    {
        string word = s.Substring(start, end - start);

        if (dict.Contains(word) && CanBreak(s, end, dict, memo))
        {
            memo[start] = true;
            return true;
        }
    }

    memo[start] = false;
    return false;
}
```

```text
s = "leetcode", dict = {leet, code}

CanBreak(0):
  ├─ word="l" → not in dict
  ├─ word="le" → not in dict
  ├─ word="lee" → not in dict
  ├─ word="leet" → in dict! → CanBreak(4)
  │   ├─ word="c" → not in dict
  │   ├─ word="co" → not in dict
  │   ├─ word="cod" → not in dict
  │   └─ word="code" → in dict! → CanBreak(8)
  │       └─ start==length → return true ✓
  └─ return true

Result: true ✓
```

- **Time Complexity:** `O(n²)` with memoization (each position computed once)
- **Space Complexity:** `O(n)` - memo dictionary + recursion stack

#### 47.2 [Dynamic Programming - Tabulation]

```csharp
public static bool WordBreak_DP(string s, IList<string> wordDict)
{
    var dictSet = new HashSet<string>(wordDict);
    var dp = new bool[s.Length + 1];
    dp[0] = true; // Empty string is always breakable

    for (int i = 1; i <= s.Length; i++)
    {
        for (int j = 0; j < i; j++)
        {
            // If s[0:j] is breakable and s[j:i] is in dict
            if (dp[j] && dictSet.Contains(s.Substring(j, i - j)))
            {
                dp[i] = true;
                break;
            }
        }
    }

    return dp[s.Length];
}
```

```text
s = "leetcode", dict = {leet, code}

dp[0] = true (empty)

i=1: s[0:1]="l" → not in dict → dp[1]=false
i=2: s[0:2]="le" → not in dict → dp[2]=false
i=3: s[0:3]="lee" → not in dict → dp[3]=false
i=4: s[0:4]="leet" → in dict, dp[0]=true → dp[4]=true ✓
i=5: s[4:5]="c" → dp[4]=true but not in dict → dp[5]=false
...
i=8: s[4:8]="code" → dp[4]=true, "code" in dict → dp[8]=true ✓

Result: dp[8] = true ✓
```

| i | s[0:i] | dp[i] | Reason |
|---|--------|-------|--------|
| 0 | "" | T | Base case |
| 1 | "l" | F | Not in dict |
| 2 | "le" | F | Not in dict |
| 3 | "lee" | F | Not in dict |
| 4 | "leet" | T | "leet" in dict |
| 5 | "leetc" | F | "c" not in dict |
| 6 | "leetco" | F | "co" not in dict |
| 7 | "leetcod" | F | "cod" not in dict |
| 8 | "leetcode" | T | "code" in dict, dp[4]=T |

- **Time Complexity:** `O(n² × m)` - n² substrings, m for substring comparison
- **Space Complexity:** `O(n)` - DP array

---

## Level 6: Array Operations (Collection Handling)


### 53. Longest Common Prefix

#### Constraints
- Input string array is not null or empty
- Strings are not null individually
- Find longest common prefix of all strings
- Return empty string if no common prefix

The string is not null.

```csharp
public static string LongestCommonPrefix(string[] strs)
{
    if (strs.Length == 0)
    {
        return "";
    }

    string smallStr = strs[0];

    for(int i = 0; i < smallStr.Length; i++)
    {
        for (int j = 1; j < strs.Length; j++)
        {
            if (i >= strs[j].Length || strs[j][i] != smallStr[i])
            {
                return smallStr.Substring(0, i);
            }
        }
    }

    return smallStr;
}
```

```text
Strings:  flower
          flow
          flight

Position 0:  f   f   f  → All 'f' ✓
Position 1:  l   l   l  → All 'l' ✓
Position 2:  o   o   i  → Mismatch! 'o' ≠ 'i' ✗

Common prefix: "fl"
```
- **Time Complexity :** `O(n*m)`
- **Space Complexity :** `O(1)`


### 48. Merge two sorted arrays
Given two sorted arrays arr1[] of size n and arr2[] of size m. Merge these two arrays.
After the merge, the first n smallest elements of the combined sorted array should be stored in arr1[], and the remaining m largest elements should be stored in arr2[]. After the merging process, both arr1[] and arr2[] must remain sorted in non-decreasing order.

```
Examples:
Input: arr1[] = [1, 3, 4, 5], arr2[] = [2, 4, 6, 8]
Output: arr1[] = [1, 2, 3, 4], arr2[] = [4 5, 6, 8]
Explanation: Combined sorted array = [1, 2, 3, 4, 4, 5, 6, 8], array arr1[] contains smallest 4 elements: 1, 2, 3, 4, and array arr2[] contains the remaining 4 elements: 4, 5, 6, 8.

Input: arr1[] = [5, 8, 9], arr2[] = [4, 7, 8]
Output: arr1[] = [4, 5, 7], arr2[] = [8, 8, 9]
Explanation: Combined sorted array = [4, 5, 7, 8, 8, 9], array arr1[] contains smallest 3 elements: 4, 5, 7, and array arr2[] contains the remaining 3 elements: 8, 8, 9.

```

```csharp
public int[] MergeSortedArrays(int[] num1, int[] num2)
 {
     int m = num1.Length;
     int n = num2.Length;
     int[] mergedArray = new int[m + n];
     int i = 0, j = 0, k = 0;
     while (i < m && j < n)
     {
         if (num1[i] <= num2[j])
         {
             mergedArray[k++] = num1[i++];
         }
         else
         {
             mergedArray[k++] = num2[j++];
         }
     }
     // Copy remaining elements of num1, if any
     while (i < m)
     {
         mergedArray[k++] = num1[i++];
     }
     // Copy remaining elements of num2, if any
     while (j < n)
     {
         mergedArray[k++] = num2[j++];
     }
     return mergedArray;
 }
```
```
num1:  [1]   3   5   7
         ↑ →   →   →   → end
num2:  [2]   4   6   8   9
         ↑ →   →   →   →   → end

Comparison sequence:
1 vs 2 → 1 ✓
3 vs 2 → 2 ✓
3 vs 4 → 3 ✓
5 vs 4 → 4 ✓
5 vs 6 → 5 ✓
7 vs 6 → 6 ✓
7 vs 8 → 7 ✓
Remaining: 8, 9 ✓
```
- **Time Complexity :** `O(n + m)`
- **Space Complexity :** `O(n + m)`

## Level 7: Stack Operations

### 49. Valid Parentheses

#### Constraints
- Input string is not null
- Contains three types: (), {}, []
- Every opening bracket has matching closing bracket
- Brackets must be closed in correct order
- Assume input contains only bracket characters

The string is not null.

```
s = "({[]})"
Result: true ✓
```

#### 49.1 [Brute Force - Multiple If-Else]

```csharp
public static bool IsValid(string s)
 {

     if (s.Length % 2 != 0)
     {
         return false;
     }

     Stack<char> braces = new Stack<char>();
     foreach (char ch in s)
     {

         if (braces.Count == 0)
         {
             braces.Push(ch);
             continue;
         }

         if (ch == ')' && braces.Peek() == '(')
         {
             braces.Pop();
         }
         else if (ch == '}' && braces.Peek() == '{')
         {
             braces.Pop();
         }
         else if (ch == ']' && braces.Peek() == '[')
         {
             braces.Pop();
         }
         else
         {
             braces.Push(ch);
         }

     }

     return braces.Count == 0;
 }

```

```
String:  {  [  (  )  ]  }
         1  2  3  4  5  6

Step 1: Push { → Stack: {
Step 2: Push [ → Stack: { [
Step 3: Push ( → Stack: { [ (
Step 4: ) matches ( → Pop ( → Stack: { [
Step 5: ] matches [ → Pop [ → Stack: {
Step 6: } matches { → Pop { → Stack: EMPTY

All matched → Valid ✓
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

#### 49.2 [Bracket Mapping - Dictionary]

The current solution requires multiple if-else statements for bracket matching. We can optimize code clarity and slightly improve performance using a **dictionary** for bracket pair mapping.

```csharp
public static bool IsValidWithMapping(string s)
{
    // Early exit for odd-length strings (can't be balanced)
    if (s.Length % 2 != 0)
    {
        return false;
    }

    // Define bracket pair mapping
    Dictionary<char, char> bracketMap = new Dictionary<char, char>
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };

    Stack<char> stack = new Stack<char>();

    foreach (char ch in s)
    {
        // If current char is a closing bracket
        if (bracketMap.ContainsKey(ch))
        {
            // Check if stack is empty or top doesn't match
            if (stack.Count == 0 || stack.Pop() != bracketMap[ch])
            {
                return false;
            }
        }
        else
        {
            // Current char is an opening bracket
            stack.Push(ch);
        }
    }

    // Valid if stack is empty (all brackets matched)
    return stack.Count == 0;
}
```

```text
String: ({[]})
Bracket map: { ')' → '(', '}' → '{', ']' → '[' }

Position 0: ch='(' → Opening bracket → Push (
  Stack: (

Position 1: ch='{' → Opening bracket → Push {
  Stack: ( {

Position 2: ch='[' → Opening bracket → Push [
  Stack: ( { [

Position 3: ch=']' → Closing bracket
  Check: bracketMap[']'] = '[', stack.Pop() = '[' ✓ Match!
  Stack: ( {

Position 4: ch='}' → Closing bracket
  Check: bracketMap['}'] = '{', stack.Pop() = '{' ✓ Match!
  Stack: (

Position 5: ch=')' → Closing bracket
  Check: bracketMap[')'] = '(', stack.Pop() = '(' ✓ Match!
  Stack: EMPTY

Return: stack.Count == 0 → true ✓

All brackets matched in order!
```

**Advantages of Mapping Approach:**

```text
Original (Multiple if-else):
  if (ch == ')' && braces.Peek() == '(') { braces.Pop(); }
  else if (ch == '}' && braces.Peek() == '{') { braces.Pop(); }
  else if (ch == ']' && braces.Peek() == '[') { braces.Pop(); }
  else { braces.Push(ch); }

Problems:
  - 3 separate comparisons per character
  - Redundant bracket pushing logic
  - Not scalable to more bracket types

Optimized (Dictionary Mapping):
  if (bracketMap.ContainsKey(ch)) {
    if (stack.Pop() != bracketMap[ch]) return false;
  } else {
    stack.Push(ch);
  }

Benefits:
  - Cleaner, more readable code
  - Easily extensible for more bracket types
  - Dictionary lookup is O(1) average case
  - Single code path for all closing brackets
```

**Comparison:**

| Aspect | Original | Mapping |
|--------|----------|---------|
| **Closing bracket detection** | 3 separate if-else | Dictionary contains check |
| **Matching logic** | Repeated in each condition | Unified with dictionary lookup |
| **Extensibility** | Add more if-else for new types | Just add to dictionary |
| **Code lines** | 10+ | 6-8 |
| **Logic clarity** | Verbose | Clear intent |

- **Time Complexity :** `O(n)`
    - Single pass through string
    - Stack operations (push/pop): O(1)
    - Dictionary operations (contains/lookup): O(1) average
- **Space Complexity :** `O(n)`
    - Stack size: O(n) in worst case (all opening brackets)
    - Dictionary size: O(1) constant (always 3 bracket pairs)

### 50. Evaluate Reverse Polish Notation
You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.

The string is not null.

```
Example 1:
Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:
Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:
Input: tokens = ["10","6","9","3","+","-11","*","/","*","17","+","5","+"]
Output: 22

```

```csharp
public static int EvalRPN(string[] tokens)
{
    var stack = new Stack<int>();
    foreach (var token in tokens)
    {
        // if token is a number, push it onto the stack
        if (int.TryParse(token, out int number))
        {
            stack.Push(number);
        }
        else
        {
            // token is an operator, pop two numbers from the stack
            int b = stack.Pop();
            int a = stack.Pop();
            int result = token switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => throw new InvalidOperationException("Invalid operator")
            };
            // push the result back onto the stack
            stack.Push(result);
        }
    }
    // return the final result
    return stack.Pop();

}

```
tokens = ["4", "13", "5", "/", "+"]
1. Push 4 → Stack: [4]
2. Push 13 → Stack: [4, 13]
3. Push 5 → Stack: [4, 13, 5]
4. "/" → Pop 5, Pop 13 → 13 / 5 = 2 → Push 2 → Stack: [4, 2]
5. "+" → Pop 2, Pop 4 → 4 + 2 = 6 → Push 6 → Stack: [6]

Return: 6 ✓
```
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

### 51. Remove All Adjacent Duplicates In String
You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.
We repeatedly make duplicate removals on s until we no longer can.
Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.

```
Example 1:
Input: s = "abbaca"
Output: "ca"
Explanation:
For example, in "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.  The result of this move is that the string is "aaca", of which only "aa" is possible, so the final string is "ca".

```

```csharp
public static string RemoveDuplicates(string s)
{
    // Use a StringBuilder as a stack-like structure
    var sb = new StringBuilder(s.Length);

    foreach (char ch in s)
    {
        int lastIndex = sb.Length - 1;

        if (lastIndex >= 0 && sb[lastIndex] == ch)
        {
            sb.Length--;  // pop last character
        }
        else
        {
            sb.Append(ch); // push
        }
    }

    return sb.ToString();
}

```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

### 58. Min Stack

#### Constraints
- Design stack with push, pop, top, and getMin operations
- All operations must be O(1) time complexity
- Stack is not null
- Values are integers

Design a stack that supports push, pop, top, and retrieving the minimum element in constant time O(1).

```
Operations:
- push(x): Push element x onto stack
- pop(): Remove top element
- top(): Get top element
- getMin(): Get minimum element in O(1)
```

#### 58.1 [Auxiliary Stack]

```csharp
public class MinStack
{
    private Stack<int> mainStack;
    private Stack<int> minStack;  // Auxiliary stack to track minimums

    public MinStack()
    {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        mainStack.Push(val);

        // Push to minStack: either val or current min
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }

    public void Pop()
    {
        if (mainStack.Peek() == minStack.Peek())
        {
            minStack.Pop();
        }
        mainStack.Pop();
    }

    public int Top() => mainStack.Peek();

    public int GetMin() => minStack.Peek();
}
```

```text
Operations:
push(3)  → Main: [3], Min: [3]
push(2)  → Main: [3,2], Min: [3,2]
push(4)  → Main: [3,2,4], Min: [3,2] (4 > 2, don't push)
push(1)  → Main: [3,2,4,1], Min: [3,2,1]

getMin() → 1 ✓ (O(1) lookup)

pop()    → Main: [3,2,4], Min: [3,2] (1 != 2, only pop main)
pop()    → Main: [3,2], Min: [3,2] (4 != 2, only pop main)
pop()    → Main: [3], Min: [3] (2 == 2, pop both)

getMin() → 3 ✓
```

- **Time Complexity:** All operations O(1)
- **Space Complexity:** `O(n)` - two stacks

#### 58.2 [Single Stack Optimized]

```csharp
public class MinStackOptimized
{
    private Stack<int> stack;
    private int currentMin;

    public MinStackOptimized()
    {
        stack = new Stack<int>();
        currentMin = int.MaxValue;
    }

    public void Push(int val)
    {
        // If new value is <= current min, push the old min first
        if (val <= currentMin)
        {
            stack.Push(currentMin);
            currentMin = val;
        }
        stack.Push(val);
    }

    public void Pop()
    {
        if (stack.Pop() == currentMin)
        {
            currentMin = stack.Pop();
        }
    }

    public int Top() => stack.Peek();

    public int GetMin() => currentMin;
}
```

- **Time Complexity:** All operations O(1)
- **Space Complexity:** `O(n)` - only one stack

---

### 59. Next Greater Element

#### Constraints
- Array contains positive integers
- Find next greater element to the right
- Return -1 if no greater element exists
- Use stack for O(n) solution

Given an array, for each element find the next greater element to its right. If not found, return -1.

```
Example: [1, 3, 4, 2]
- 1: next greater = 3
- 3: next greater = 4
- 4: next greater = -1
- 2: next greater = -1

Result: [3, 4, -1, -1]
```

#### 59.1 [Brute Force - Linear Search]

```csharp
public static int[] NextGreaterElement_BruteForce(int[] nums)
{
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = -1;
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] > nums[i])
            {
                result[i] = nums[j];
                break;
            }
        }
    }

    return result;
}
```

- **Time Complexity:** `O(n²)` - nested loops
- **Space Complexity:** `O(n)` - result array

#### 59.2 [Monotonic Stack - O(n)]

```csharp
public static int[] NextGreaterElement_MonotonicStack(int[] nums)
{
    int[] result = new int[nums.Length];
    Array.Fill(result, -1);
    Stack<int> stack = new();  // Store indices

    // Traverse from right to left
    for (int i = nums.Length - 1; i >= 0; i--)
    {
        // Pop all smaller elements
        while (stack.Count > 0 && nums[stack.Peek()] <= nums[i])
        {
            stack.Pop();
        }

        // Top of stack is next greater (if exists)
        if (stack.Count > 0)
        {
            result[i] = nums[stack.Peek()];
        }

        // Push current index
        stack.Push(i);
    }

    return result;
}
```

```text
nums: [1, 3, 4, 2]

i=3 (val=2): Stack empty → result[3]=-1, Push 3
  Stack: [3]

i=2 (val=4): nums[3]=2 <= 4? YES, Pop 3 → Empty
  Stack empty → result[2]=-1, Push 2
  Stack: [2]

i=1 (val=3): nums[2]=4 > 3? YES, KEEP
  result[1]=4, Push 1
  Stack: [2, 1]

i=0 (val=1): nums[1]=3 > 1? YES, KEEP
  result[0]=3, Push 0
  Stack: [2, 1, 0]

Result: [3, 4, -1, -1] ✓
```

- **Time Complexity:** `O(n)` - each element pushed/popped once
- **Space Complexity:** `O(n)` - stack size

---

### 60. Daily Temperatures

#### Constraints
- Input array contains daily temperatures
- Find days until warmer temperature
- Return 0 if no warmer day exists
- O(n) time using stack preferred

Given an array of temperatures, return for each day how many days you have to wait until a warmer temperature.

```
Example: [73, 74, 75, 71, 69, 72, 76, 73]
- Day 0 (73°): Wait 1 day → 74°
- Day 1 (74°): Wait 1 day → 75°
- Day 2 (75°): Wait 4 days → 76°
- Day 3 (71°): Wait 1 day → 72°
- Day 4 (69°): Wait 1 day → 72°
- Day 5 (72°): Wait 1 day → 76°
- Day 6 (76°): No warmer → 0
- Day 7 (73°): No warmer → 0

Result: [1, 1, 4, 2, 1, 1, 0, 0]
```

#### 60.1 [Brute Force - Linear Search]

```csharp
public static int[] DailyTemperatures_BruteForce(int[] temperatures)
{
    int[] result = new int[temperatures.Length];

    for (int i = 0; i < temperatures.Length; i++)
    {
        for (int j = i + 1; j < temperatures.Length; j++)
        {
            if (temperatures[j] > temperatures[i])
            {
                result[i] = j - i;
                break;
            }
        }
    }

    return result;
}
```

- **Time Complexity:** `O(n²)`
- **Space Complexity:** `O(n)`

#### 60.2 [Monotonic Stack - O(n)]

```csharp
public static int[] DailyTemperatures_MonotonicStack(int[] temperatures)
{
    int[] result = new int[temperatures.Length];
    Stack<int> stack = new();  // Store indices of decreasing temperatures

    for (int i = 0; i < temperatures.Length; i++)
    {
        // While current temp is warmer than stack top
        while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
        {
            int prevIndex = stack.Pop();
            result[prevIndex] = i - prevIndex;
        }

        stack.Push(i);
    }

    return result;
}
```

```text
temperatures: [73, 74, 75, 71, 69, 72, 76, 73]

i=0 (73°): Stack empty → Push 0
  Stack: [0]

i=1 (74°): 74 > 73? YES
  Pop 0, result[0] = 1 - 0 = 1 ✓
  Push 1
  Stack: [1]

i=2 (75°): 75 > 74? YES
  Pop 1, result[1] = 2 - 1 = 1 ✓
  Push 2
  Stack: [2]

i=3 (71°): 71 > 75? NO → Push 3
  Stack: [2, 3]

i=4 (69°): 69 > 71? NO → Push 4
  Stack: [2, 3, 4]

i=5 (72°): 72 > 69? YES → Pop 4, result[4] = 1 ✓
          72 > 71? YES → Pop 3, result[3] = 2 ✓
          72 > 75? NO → Push 5
  Stack: [2, 5]

i=6 (76°): 76 > 72? YES → Pop 5, result[5] = 1 ✓
          76 > 75? YES → Pop 2, result[2] = 4 ✓
          Push 6
  Stack: [6]

i=7 (73°): 73 > 76? NO → Push 7
  Stack: [6, 7]

Result: [1, 1, 4, 2, 1, 1, 0, 0] ✓
```

- **Time Complexity:** `O(n)` - each element processed once
- **Space Complexity:** `O(n)`

---

### 61. Largest Rectangle in Histogram

#### Constraints
- Heights array is not empty
- All values are non-negative integers
- Find largest rectangle area in histogram
- O(n) solution using stack preferred

Given an array of heights representing a histogram, find the largest rectangle area.

```
Example: [2, 1, 5, 6, 2, 3]

Visual:
    6 |       █
    5 |       █ █
    4 |   █   █ █
    3 | █ █ █ █ █
    2 | █ █ █ █ █
    1 | █ █ █ █ █
      ├─┼─┼─┼─┼─┼──
      0 1 2 3 4 5

Largest rectangle: between indices 2-3, height 5 → area = 5×2 = 10
```

#### 61.1 [Brute Force - All Pairs]

```csharp
public static int LargestRectangleArea_BruteForce(int[] heights)
{
    int maxArea = 0;

    for (int i = 0; i < heights.Length; i++)
    {
        int minHeight = heights[i];

        for (int j = i; j < heights.Length; j++)
        {
            minHeight = Math.Min(minHeight, heights[j]);
            int area = minHeight * (j - i + 1);
            maxArea = Math.Max(maxArea, area);
        }
    }

    return maxArea;
}
```

- **Time Complexity:** `O(n²)`
- **Space Complexity:** `O(1)`

#### 61.2 [Monotonic Stack - O(n)]

```csharp
public static int LargestRectangleArea_MonotonicStack(int[] heights)
{
    Stack<int> stack = new();
    int maxArea = 0;

    for (int i = 0; i < heights.Length; i++)
    {
        // Pop and calculate area for heights taller than current
        while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
        {
            int h = heights[stack.Pop()];
            int w = stack.Count > 0 ? i - stack.Peek() - 1 : i;
            int area = h * w;
            maxArea = Math.Max(maxArea, area);
        }

        stack.Push(i);
    }

    // Process remaining heights
    while (stack.Count > 0)
    {
        int h = heights[stack.Pop()];
        int w = stack.Count > 0 ? heights.Length - stack.Peek() - 1 : heights.Length;
        int area = h * w;
        maxArea = Math.Max(maxArea, area);
    }

    return maxArea;
}
```

- **Time Complexity:** `O(n)`
- **Space Complexity:** `O(n)`

---

### 62. Decode String

#### Constraints
- Input string contains valid encoded format: `k[encoded_string]`
- k is a positive integer
- Brackets may be nested
- String contains only lowercase letters and numbers

Given an encoded string, decode it. The encoding rule is: `k[encoded_string]`, where k is a number and represents repeating the `encoded_string` k times.

```
Examples:
- "3[a]2[bc]" → "aaabcbc"
- "3[a2[c]]" → "accaccacc"
- "2[abc]3[cd]eaea.at" → "abcabccdcdcdeaea.at"
```

#### 62.1 [Recursion with Stack]

```csharp
public static string DecodeString_Recursion(string s)
{
    Stack<(StringBuilder, int)> stack = new();
    StringBuilder current = new();
    int num = 0;

    foreach (char c in s)
    {
        if (char.IsDigit(c))
        {
            num = num * 10 + (c - '0');
        }
        else if (c == '[')
        {
            // Save current state and start new
            stack.Push((current, num));
            current = new StringBuilder();
            num = 0;
        }
        else if (c == ']')
        {
            // Pop and repeat
            var (prevStr, count) = stack.Pop();
            string temp = current.ToString();
            current = prevStr;
            for (int i = 0; i < count; i++)
            {
                current.Append(temp);
            }
        }
        else
        {
            current.Append(c);
        }
    }

    return current.ToString();
}
```

```text
Input: "3[a2[c]]"

c='3': num=3
c='[': Push (new StringBuilder, 3), current=empty, num=0
c='a': current="a"
c='2': num=2
c='[': Push (current="a", 2), current=empty, num=0
c='c': current="c"
c=']': Pop (prev="a", count=2)
       temp="c", current="a" + "c"×2 = "acc"
c=']': Pop (prev=empty, count=3)
       temp="acc", current = "acc"×3 = "accaccacc"

Result: "accaccacc" ✓
```

- **Time Complexity:** `O(max_k^max_depth × n)` where k is max multiplier
- **Space Complexity:** `O(m)` where m is decoded string length

#### 62.2 [Iterative Stack Approach]

```csharp
public static string DecodeString_Iterative(string s)
{
    Stack<string> strStack = new();
    Stack<int> numStack = new();
    string current = "";
    int num = 0;

    foreach (char c in s)
    {
        if (char.IsDigit(c))
        {
            num = num * 10 + (c - '0');
        }
        else if (c == '[')
        {
            // Push to stacks
            numStack.Push(num);
            strStack.Push(current);
            current = "";
            num = 0;
        }
        else if (c == ']')
        {
            // Pop and build
            int count = numStack.Pop();
            string prev = strStack.Pop();
            string temp = "";
            for (int i = 0; i < count; i++)
            {
                temp += current;
            }
            current = prev + temp;
        }
        else
        {
            current += c;
        }
    }

    return current;
}
```

- **Time Complexity:** `O(max_k^max_depth × n)`
- **Space Complexity:** `O(m)`

---

## Level 8: Binary Search & Searching (Divide & Conquer Search)

### 63. Find First and Last Position of an Element in Sorted Array

**Description:** Find first and last positions of target in sorted array, return [-1,-1] if not found.

**Examples:**
```
Input: nums = [5,7,7,8,8,10], target = 8
Output: [3,4]
Explanation: First 8 at index 3, last 8 at index 4

Input: nums = [5,7,7,8,8,10], target = 6
Output: [-1,-1]
Explanation: Target 6 not found

Input: nums = [8], target = 8
Output: [0,0]
Explanation: Single element
```

#### Constraints
- Input array is sorted in ascending order
- Find first and last position of target
- Return [-1, -1] if target not found
- O(log n) time complexity required

```csharp
public static List<int> FindFirstAndLastPositionOfAnElement(int[] sortedArray, int target)
{
    var result = new List<int> { -1, -1 };
    int left = 0;
    int right = sortedArray.Length - 1;
    // Find the first occurrence
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (sortedArray[mid] >= target)
        {
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }
    // Check if the target is not found
    if (left >= sortedArray.Length || sortedArray[left] != target)
    {
        return result;
    }
    result[0] = left; // First occurrence
    // Find the last occurrence
    right = sortedArray.Length - 1; // Reset right pointer
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (sortedArray[mid] <= target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    result[1] = right; // Last occurrence
    return result;
}
```

```
Array: [5, 7, 7, 8, 8, 10]
Index:  0  1  2  3  4  5
Target: 8

First occurrence search:
  Binary search for "first 8"
  Finds index 3
  Check: arr[3] = 8 ✓

Last occurrence search:
  Binary search for "last 8"
  Starts from index 3
  Finds index 4
  Check: arr[4] = 8 ✓

Result: [3, 4]
```
- **Time Complexity :** `O(log n)`
    - First binary search: O(log n)
    - Second binary search: O(log n)
    - Total: O(2 log n) = O(log n)
- **Space Complexity :** `O(1)`

### 64. Search in Rotated Sorted Array
There is an integer array nums sorted in ascending order (with distinct values).
Prior to being passed to your function, nums is possibly left rotated at an unknown index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be left rotated by 3 indices and become [4,5,6,7,0,1,2].
Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.
You must write an algorithm with O(log n) runtime complexity.

```
Example 1:
Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
Example 2:
Input: nums = [4,5,6,7,0,1,2], target = 3
Output: -1
Example 3:
Input: nums = [1], target = 0
Output: -1

```

```csharp
public static int Search(int[] nums, int target)
{
    // rotacted array binary search
    int left = 0;
    int right = nums.Length - 1;
    while (left <= right)
    {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target)
        {
            return mid;
        }
        // Left half is sorted
        if (nums[left] <= nums[mid])
        {
            if (target >= nums[left] && target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        else
        { // Right half is sorted
            if (target > nums[mid] && target <= nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
    }
    return -1;
}

```
```
Array: [4, 5, 6, 7, 0, 1, 2]
Index:  0  1  2  3  4  5  6
        ---------  ---------
        Sorted     Sorted
        left half  right half
        (4-7)      (0-2)

Target: 0

Step 1: mid=3 (value 7)
  Left half [4,5,6,7] is sorted
  Target 0 not in [4,7] range → search right half

Step 2: New range [4,5,6] → indices 4-6
  mid=5 (value 1)
  Left half [0,1] (indices 4-5) is sorted
  Target 0 in [0,1] range → search left half

Step 3: New range [4,4] → index 4
  Found target 0 at index 4
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

### 65. Find Minimum Element in Sorted Rotated Array
Suppose an array of length n sorted in ascending order is rotated between 1 and n times. For example, the array nums = [0,1,2,4,5,6,7] might become:
•	[4,5,6,7,0,1,2] if it was rotated 4 times.
•	[0,1,2,4,5,6,7] if it was rotated 7 times.
Notice that rotating an array [a[0], a[1], a[2], ..., a[n-1]] 1 time results in the array [a[n-1], a[0], a[1], a[2], ..., a[n-2]].
Given the sorted rotated array nums of unique elements, return the minimum element of this array.
You must write an algorithm that runs in O(log n) time.

```
Example 1:
Input: nums = [3,4,5,1,2]
Output: 1
Explanation: The original array was [1,2,3,4,5] rotated 3 times.
Example 2:
Input: nums = [4,5,6,7,0,1,2]
Output: 0
Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.
Example 3:
Input: nums = [11,13,15,17]
Output: 11
Explanation: The original array was [11,13,15,17] and it was rotated 4 times.

```

```csharp
public static int FindMin(int[] nums)
{
    int start = 0;
    int end = nums.Length - 1;

    while (start < end)
    {
        int mid = start + (end - start) / 2;

        // Minimum is in the right half
        if (nums[mid] > nums[end])
        {
            start = mid + 1;
        }
        // Minimum is in the left half (including mid)
        else
        {
            end = mid;
        }
    }

    return nums[start];
}

```

```
Array: [4, 5, 6, 7, 0, 1, 2]
        ↑                 ↑
       start=0           end=6
       mid=3 → nums[3]=7 > nums[6]=2 → min in right → start=4

New range: [4, 5, 6, 7, 0, 1, 2]
                      ↑     ↑
                    start=4 end=6
                    mid=5 → nums[5]=1 ≤ nums[6]=2 → min in left → end=5

New range: [4, 5, 6, 7, 0, 1, 2]
                      ↑  ↑
                    start=4 end=5
                    mid=4 → nums[4]=0 ≤ nums[5]=1 → min in left → end=4

Found: nums[4] = 0
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

---

### 66. Two Sum

#### Constraints
- Array contains positive integers
- Exactly one solution exists (two different indices)
- Cannot use same element twice
- Return array of [index1, index2] where index1 < index2

Given an array of integers `nums` and an integer `target`, return the indices of the two numbers that add up to the target. You may assume each input has exactly one solution, and you cannot use the same element twice.

**Constraints:**
- You must return the indices (not values)
- Cannot use same element twice
- Return in any order

```
Examples:
Input: nums = [2, 7, 11, 15], target = 9
Output: [0, 1] (because nums[0] + nums[1] = 2 + 7 = 9)

Input: nums = [3, 3], target = 6
Output: [0, 1] (because nums[0] + nums[1] = 3 + 3 = 6)
```

#### 51.1 [Brute Force - Nested Loop]

Check all pairs of numbers to find the two that sum to target.

```csharp
public static int[] TwoSumBruteForce(int[] nums, int target)
{
    // Check every pair
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {
                return new int[] { i, j };
            }
        }
    }

    return new int[] { -1, -1 }; // No solution found
}
```

```
nums = [2, 7, 11, 15], target = 9

i=0, j=1: 2+7=9 ✓ → Return [0, 1]

Without early exit (showing all comparisons):
i=0: j=1 (2+7=9✓), j=2 (2+11=13✗), j=3 (2+15=17✗)
i=1: j=2 (7+11=18✗), j=3 (7+15=22✗)
i=2: j=3 (11+15=26✗)
```

- **Time Complexity :** `O(n²)`
    - Nested loops checking all pairs
- **Space Complexity :** `O(1)`
    - Only using constant space

#### 51.2 [Hash Map - Two Pass]

Use a hash map to store seen numbers and their indices. For each number, check if `target - number` exists in the map.

```csharp
public static int[] TwoSumHashMap(int[] nums, int target)
{
    // Dictionary to store value → index mapping
    var numMap = new Dictionary<int, int>();

    // Store all numbers and their indices
    for (int i = 0; i < nums.Length; i++)
    {
        numMap[nums[i]] = i;
    }

    // Check each number to find its complement
    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        // Check if complement exists and is not the same element
        if (numMap.ContainsKey(complement) && numMap[complement] != i)
        {
            return new int[] { i, numMap[complement] };
        }
    }

    return new int[] { -1, -1 };
}
```

```
nums = [2, 7, 11, 15], target = 9

Step 1: Build HashMap
numMap = { 2→0, 7→1, 11→2, 15→3 }

Step 2: Find complement for each number
i=0: nums[0]=2, complement=9-2=7
     7 exists in map at index 1 ✓
     Return [0, 1]
```

- **Time Complexity :** `O(n)`
    - First pass: O(n) to build hash map
    - Second pass: O(n) to find complement
    - Total: O(n) + O(n) = O(n)
- **Space Complexity :** `O(n)`
    - Hash map stores up to n elements

**Alternative: One-Pass Hash Map (Even Better)**
```csharp
public static int[] TwoSumOnePass(int[] nums, int target)
{
    var numMap = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        // Check if complement was already seen
        if (numMap.ContainsKey(complement))
        {
            return new int[] { numMap[complement], i };
        }

        // Store current number for future checks
        numMap[nums[i]] = i;
    }

    return new int[] { -1, -1 };
}
```

---

### 67. Search in 2D Sorted Matrix

#### Constraints
- Matrix is m × n size
- Rows are sorted in ascending order (left to right)
- Columns are sorted in ascending order (top to bottom)
- Target value may not exist in matrix
- O(m + n) or O(log m + log n) time preferred

Given an `m × n` matrix where rows and columns are sorted in ascending order, search for a target value. Return true if found, false otherwise.

**Constraints:**
- Rows sorted left to right
- Columns sorted top to bottom
- Matrix is not necessarily sorted overall

```
Example:
Matrix:
[1,  4,  7, 11, 15]
[2,  5,  8, 12, 19]
[3,  6,  9, 16, 22]
[10, 13, 14, 17, 24]
[18, 21, 23, 26, 30]

Search for 13: Found at [3, 1]
Search for 20: Not found
```

#### 52.1 [Brute Force - Linear Search]

Check every element in the matrix sequentially.

```csharp
public static bool SearchMatrixBruteForce(int[][] matrix, int target)
{
    // Check every element
    foreach (int[] row in matrix)
    {
        foreach (int num in row)
        {
            if (num == target)
                return true;
        }
    }

    return false;
}
```

- **Time Complexity :** `O(m × n)`
    - Check all m rows and n columns
- **Space Complexity :** `O(1)`

#### 52.2 [Binary Search - Staircase Search]

Start from top-right corner (or bottom-left). If current element is less than target, move down; if greater, move left. This eliminates one row or column per step.

```csharp
public static bool SearchMatrixStaircase(int[][] matrix, int target)
{
    int m = matrix.Length;        // rows
    int n = matrix[0].Length;      // columns

    // Start from top-right corner
    int row = 0;
    int col = n - 1;

    while (row < m && col >= 0)
    {
        if (matrix[row][col] == target)
        {
            return true;
        }

        if (matrix[row][col] < target)
        {
            // Current element too small, move down
            row++;
        }
        else
        {
            // Current element too large, move left
            col--;
        }
    }

    return false;
}
```

```
Matrix:
[1,  4,  7, 11, 15]    row 0
[2,  5,  8, 12, 19]    row 1
[3,  6,  9, 16, 22]    row 2
[10, 13, 14, 17, 24]   row 3
[18, 21, 23, 26, 30]   row 4
     ↑                   ↑
   col 1               col 4 (start)

Search for 13:
Start: [0, 4] = 15 > 13 → col--
       [0, 3] = 11 < 13 → row++
       [1, 3] = 12 < 13 → row++
       [2, 3] = 16 > 13 → col--
       [2, 2] = 9 < 13 → row++
       [3, 2] = 14 > 13 → col--
       [3, 1] = 13 = 13 → Found! ✓
```

- **Time Complexity :** `O(m + n)`
    - At most m down moves + n left moves
- **Space Complexity :** `O(1)`
    - Only using constant space

---

### 68. Spiral Matrix Traversal

#### Constraints
- Matrix is m × n size
- Traverse clockwise from outside to inside
- Visit all elements exactly once
- Return result as single array

Given an `m × n` matrix, return all elements of the matrix in spiral order (clockwise from outside to inside).

```
Example:
[1,  2,  3]
[4,  5,  6]
[7,  8,  9]

Spiral: [1, 2, 3, 6, 9, 8, 7, 4, 5]
```

#### 53.1 [Brute Force - Layer by Layer]

Process the matrix layer by layer, moving right → down → left → up, then shrink boundaries.

```csharp
public static List<int> SpiralMatrixLayerByLayer(int[][] matrix)
{
    var result = new List<int>();

    int top = 0, bottom = matrix.Length - 1;
    int left = 0, right = matrix[0].Length - 1;

    while (top <= bottom && left <= right)
    {
        // Move right along top row
        for (int col = left; col <= right; col++)
        {
            result.Add(matrix[top][col]);
        }
        top++;

        // Move down along right column
        for (int row = top; row <= bottom; row++)
        {
            result.Add(matrix[row][right]);
        }
        right--;

        // Move left along bottom row (if exists)
        if (top <= bottom)
        {
            for (int col = right; col >= left; col--)
            {
                result.Add(matrix[bottom][col]);
            }
            bottom--;
        }

        // Move up along left column (if exists)
        if (left <= right)
        {
            for (int row = bottom; row >= top; row--)
            {
                result.Add(matrix[row][left]);
            }
            left++;
        }
    }

    return result;
}
```

```
Matrix:
[1,  2,  3]
[4,  5,  6]
[7,  8,  9]

Layer 1:
→ Right: 1, 2, 3
↓ Down: 6, 9
← Left: 8, 7
↑ Up: 4

Layer 2:
  5 (center)

Result: [1, 2, 3, 6, 9, 8, 7, 4, 5]
```

- **Time Complexity :** `O(m × n)`
    - Visit each element exactly once
- **Space Complexity :** `O(1)` (excluding output list)

#### 53.2 [Optimized - Boundary Tracking]

Same approach but cleaner implementation with early termination checks.

```csharp
public static List<int> SpiralMatrixOptimized(int[][] matrix)
{
    var result = new List<int>();

    int top = 0, bottom = matrix.Length - 1;
    int left = 0, right = matrix[0].Length - 1;

    while (top <= bottom && left <= right)
    {
        // Traverse right
        for (int col = left; col <= right; col++)
        {
            result.Add(matrix[top][col]);
        }
        top++;

        // Traverse down
        for (int row = top; row <= bottom; row++)
        {
            result.Add(matrix[row][right]);
        }
        right--;

        // Traverse left (only if row exists)
        if (top <= bottom)
        {
            for (int col = right; col >= left; col--)
            {
                result.Add(matrix[bottom][col]);
            }
            bottom--;
        }

        // Traverse up (only if column exists)
        if (left <= right)
        {
            for (int row = bottom; row >= top; row--)
            {
                result.Add(matrix[row][left]);
            }
            left++;
        }
    }

    return result;
}
```

- **Time Complexity :** `O(m × n)`
- **Space Complexity :** `O(1)`

---

## Level 9: Linked List (Linear Data Structure with Pointers)

> `Iterative & Recursive techniques`

### 54. Reverse a Linked List

#### 54.1 [Brute Force - Iterative]

**Pseudocode:**
```
FUNCTION ReverseIterative(head)
  prev ← NULL
  current ← head
  WHILE current != NULL DO
    nextTemp ← current.next    // Save next node
    current.next ← prev        // Reverse the link
    prev ← current             // Move prev forward
    current ← nextTemp         // Move current forward
  END WHILE
  RETURN prev  // New head
END FUNCTION
```

**Code Implementation:**
```csharp
public class ListNode {
    public int val;
    public ListNode next;
}

public static ListNode ReverseIterative(ListNode head)
{
    ListNode prev = null;
    ListNode current = head;

    while (current != null)
    {
        ListNode nextTemp = current.next;
        current.next = prev;
        prev = current;
        current = nextTemp;
    }

    return prev;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

#### 54.2 [Recursive]

**Pseudocode:**
```
FUNCTION ReverseRecursive(head)
  IF head == NULL OR head.next == NULL THEN
    RETURN head
  END IF

  newHead ← ReverseRecursive(head.next)
  head.next.next ← head     // Reverse the link
  head.next ← NULL          // Remove forward link
  RETURN newHead
END FUNCTION
```

**Code Implementation:**
```csharp
public static ListNode ReverseRecursive(ListNode head)
{
    if (head == null || head.next == null)
        return head;

    ListNode newHead = ReverseRecursive(head.next);

    head.next.next = head;
    head.next = null;

    return newHead;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)` (Call stack)

---

### 55. Detect Cycle in Linked List

#### 55.1 [Brute Force - Hash Set]

**Pseudocode:**
```
FUNCTION DetectCycleHashSet(head)
  visited ← EMPTY_SET
  current ← head

  WHILE current != NULL DO
    IF current IN visited THEN
      RETURN TRUE  // Cycle found
    END IF
    visited.ADD(current)
    current ← current.next
  END WHILE

  RETURN FALSE  // No cycle
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool DetectCycleHashSet(ListNode head)
{
    var visited = new HashSet<ListNode>();
    ListNode current = head;

    while (current != null)
    {
        if (visited.Contains(current))
            return true;

        visited.Add(current);
        current = current.next;
    }

    return false;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

#### 55.2 [Two-Pointer (Floyd's Cycle Detection)]

**Pseudocode:**
```
FUNCTION DetectCycleFloyd(head)
  slow ← head
  fast ← head

  WHILE fast != NULL AND fast.next != NULL DO
    slow ← slow.next         // Move 1 step
    fast ← fast.next.next    // Move 2 steps

    IF slow == fast THEN      // Cycle detected
      RETURN TRUE
    END IF
  END WHILE

  RETURN FALSE
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool DetectCycleFloyd(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast)
            return true;
    }

    return false;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

---

### 56. Merge Two Sorted Linked Lists

#### Constraints
- Both lists are sorted in ascending order
- Lists may be of different lengths
- Return merged sorted list
- Use O(1) space (pointer manipulation only)

**Pseudocode:**
```
FUNCTION MergeSorted(list1, list2)
  dummyNode ← NEW ListNode(0)
  current ← dummyNode

  WHILE list1 != NULL AND list2 != NULL DO
    IF list1.val <= list2.val THEN
      current.next ← list1
      list1 ← list1.next
    ELSE
      current.next ← list2
      list2 ← list2.next
    END IF
    current ← current.next
  END WHILE

  current.next ← list1 != NULL ? list1 : list2
  RETURN dummyNode.next
END FUNCTION
```

**Code Implementation:**
```csharp
public static ListNode MergeSorted(ListNode list1, ListNode list2)
{
    ListNode dummy = new ListNode(0);
    ListNode current = dummy;

    while (list1 != null && list2 != null)
    {
        if (list1.val <= list2.val)
        {
            current.next = list1;
            list1 = list1.next;
        }
        else
        {
            current.next = list2;
            list2 = list2.next;
        }
        current = current.next;
    }

    current.next = list1 ?? list2;
    return dummy.next;
}
```

- **Time Complexity :** `O(n + m)`
- **Space Complexity :** `O(1)`

---

### 57. Find Middle of Linked List

#### Constraints
- Linked list node is not null
- Return middle node (if even length, return second middle)
- Use slow-fast pointer technique
- O(n) time, O(1) space

**Pseudocode:**
```
FUNCTION FindMiddle(head)
  slow ← head
  fast ← head

  WHILE fast != NULL AND fast.next != NULL DO
    slow ← slow.next       // Move 1 step
    fast ← fast.next.next  // Move 2 steps
  END WHILE

  RETURN slow  // slow is at middle
END FUNCTION
```

**Code Implementation:**
```csharp
public static ListNode FindMiddle(ListNode head)
{
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }

    return slow;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

---

### 58. Remove Nth Node From End of List

#### Constraints
- List contains at least one node
- Remove nth node from end of list
- Use two-pointer (dummy node) approach
- Return head of modified list

**Pseudocode:**
```
FUNCTION RemoveNthFromEnd(head, n)
  dummy ← NEW ListNode(0)
  dummy.next ← head

  first ← dummy
  second ← dummy

  FOR i = 0 TO n DO
    first ← first.next
  END FOR

  WHILE first.next != NULL DO
    first ← first.next
    second ← second.next
  END WHILE

  second.next ← second.next.next
  RETURN dummy.next
END FUNCTION
```

**Code Implementation:**
```csharp
public static ListNode RemoveNthFromEnd(ListNode head, int n)
{
    ListNode dummy = new ListNode(0);
    dummy.next = head;

    ListNode first = dummy;
    ListNode second = dummy;

    for (int i = 0; i <= n; i++)
    {
        first = first.next;
    }

    while (first != null)
    {
        first = first.next;
        second = second.next;
    }

    second.next = second.next.next;
    return dummy.next;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

---

### 59. Linked List Palindrome Check

#### Constraints
- Linked list node is not null
- Check if list forms a palindrome
- Use fast-slow pointer to find middle
- Reverse second half and compare

**Pseudocode:**
```
FUNCTION IsPalindrome(head)
  slow ← head
  fast ← head

  WHILE fast != NULL AND fast.next != NULL DO
    slow ← slow.next
    fast ← fast.next.next
  END WHILE

  secondHalf ← ReverseList(slow)

  first ← head
  second ← secondHalf

  WHILE second != NULL DO
    IF first.val != second.val THEN
      RETURN FALSE
    END IF
    first ← first.next
    second ← second.next
  END WHILE

  RETURN TRUE
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool IsPalindrome(ListNode head)
{
    ListNode slow = head, fast = head;
    while (fast != null && fast.next != null)
    {
        slow = slow.next;
        fast = fast.next.next;
    }

    ListNode secondHalf = ReverseIterative(slow);

    ListNode first = head;
    ListNode second = secondHalf;

    while (second != null)
    {
        if (first.val != second.val)
            return false;
        first = first.next;
        second = second.next;
    }

    return true;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)` or `O(n)`

---

## Level 10: Tree (Hierarchical Data Structure)

> `Traversal & Search techniques`

### 60. Tree Traversals (Inorder, Preorder, Postorder)

#### 60.1 [Brute Force - Recursive]

**Pseudocode (Inorder: Left → Node → Right):**
```
FUNCTION InorderTraversal(node)
  IF node == NULL THEN
    RETURN
  END IF

  InorderTraversal(node.left)      // Left
  PRINT node.val                   // Node
  InorderTraversal(node.right)     // Right
END FUNCTION
```

**Code Implementation:**
```csharp
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
}

public static void InorderRecursive(TreeNode node)
{
    if (node == null) return;

    InorderRecursive(node.left);
    Console.WriteLine(node.val);
    InorderRecursive(node.right);
}

public static void PreorderRecursive(TreeNode node)
{
    if (node == null) return;

    Console.WriteLine(node.val);     // Node first
    PreorderRecursive(node.left);
    PreorderRecursive(node.right);
}

public static void PostorderRecursive(TreeNode node)
{
    if (node == null) return;

    PostorderRecursive(node.left);
    PostorderRecursive(node.right);
    Console.WriteLine(node.val);     // Node last
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)` (h = height, call stack)

#### 60.2 [Iterative - Stack]

**Pseudocode (Inorder - Iterative):**
```
FUNCTION InorderIterative(root)
  stack ← EMPTY_STACK
  current ← root

  WHILE current != NULL OR stack NOT EMPTY DO
    // Go to leftmost node
    WHILE current != NULL DO
      stack.PUSH(current)
      current ← current.left
    END WHILE

    // Current is NULL, pop from stack
    current ← stack.POP()
    PRINT current.val

    // Visit right subtree
    current ← current.right
  END WHILE
END FUNCTION
```

**Code Implementation:**
```csharp
public static void InorderIterative(TreeNode root)
{
    var stack = new Stack<TreeNode>();
    TreeNode current = root;

    while (current != null || stack.Count > 0)
    {
        // Go to leftmost node
        while (current != null)
        {
            stack.Push(current);
            current = current.left;
        }

        // Pop and process
        current = stack.Pop();
        Console.WriteLine(current.val);

        // Visit right subtree
        current = current.right;
    }
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

---

### 61. Level Order Traversal (BFS)

#### 61.1 [Brute Force - Recursive]

**Pseudocode:**
```
FUNCTION LevelOrderRecursive(node, level, result)
  IF node == NULL THEN
    RETURN
  END IF

  IF level == result.SIZE THEN
    result.ADD(NEW List)
  END IF

  result[level].ADD(node.val)
  LevelOrderRecursive(node.left, level + 1, result)
  LevelOrderRecursive(node.right, level + 1, result)
END FUNCTION
```

**Code Implementation:**
```csharp
public static void LevelOrderRecursive(TreeNode node, int level, List<List<int>> result)
{
    if (node == null) return;

    if (level == result.Count)
        result.Add(new List<int>());

    result[level].Add(node.val);
    LevelOrderRecursive(node.left, level + 1, result);
    LevelOrderRecursive(node.right, level + 1, result);
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

#### 61.2 [Iterative - Queue]

**Pseudocode:**
```
FUNCTION LevelOrderIterative(root)
  IF root == NULL THEN
    RETURN EMPTY_LIST
  END IF

  result ← EMPTY_LIST
  queue ← EMPTY_QUEUE
  queue.ENQUEUE(root)

  WHILE queue NOT EMPTY DO
    levelSize ← queue.SIZE
    currentLevel ← EMPTY_LIST

    FOR i = 0 TO levelSize - 1 DO
      node ← queue.DEQUEUE()
      currentLevel.ADD(node.val)

      IF node.left != NULL THEN
        queue.ENQUEUE(node.left)
      END IF

      IF node.right != NULL THEN
        queue.ENQUEUE(node.right)
      END IF
    END FOR

    result.ADD(currentLevel)
  END WHILE

  RETURN result
END FUNCTION
```

**Code Implementation:**
```csharp
public static List<List<int>> LevelOrderIterative(TreeNode root)
{
    var result = new List<List<int>>();
    if (root == null) return result;

    var queue = new Queue<TreeNode>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        int levelSize = queue.Count;
        var currentLevel = new List<int>();

        for (int i = 0; i < levelSize; i++)
        {
            TreeNode node = queue.Dequeue();
            currentLevel.Add(node.val);

            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        result.Add(currentLevel);
    }

    return result;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(w)` (w = max width)

---

### 62. Binary Search Tree Validation

#### 62.1 [Brute Force - Min/Max Range]

**Pseudocode:**
```
FUNCTION IsValidBST(node, minVal, maxVal)
  IF node == NULL THEN
    RETURN TRUE
  END IF

  IF node.val <= minVal OR node.val >= maxVal THEN
    RETURN FALSE
  END IF

  RETURN IsValidBST(node.left, minVal, node.val) AND
         IsValidBST(node.right, node.val, maxVal)
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool IsValidBST(TreeNode node, long minVal = long.MinValue, long maxVal = long.MaxValue)
{
    if (node == null) return true;

    if (node.val <= minVal || node.val >= maxVal)
        return false;

    return IsValidBST(node.left, minVal, node.val) &&
           IsValidBST(node.right, node.val, maxVal);
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

#### 62.2 [Optimized - Recursive Range Check]

**Pseudocode:**
```
FUNCTION IsValidBSTOptimized(node, minVal, maxVal)
  IF node == NULL THEN
    RETURN TRUE
  END IF

  IF (minVal != NULL AND node.val <= minVal) OR
     (maxVal != NULL AND node.val >= maxVal) THEN
    RETURN FALSE
  END IF

  RETURN IsValidBSTOptimized(node.left, minVal, node.val) AND
         IsValidBSTOptimized(node.right, node.val, maxVal)
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool IsValidBSTOptimized(TreeNode node, long? minVal = null, long? maxVal = null)
{
    if (node == null) return true;

    if ((minVal != null && node.val <= minVal) ||
        (maxVal != null && node.val >= maxVal))
        return false;

    return IsValidBSTOptimized(node.left, minVal, node.val) &&
           IsValidBSTOptimized(node.right, node.val, maxVal);
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

---

### 63. Lowest Common Ancestor (LCA)

#### 63.1 [Brute Force - Store Path]

**Pseudocode:**
```
FUNCTION FindLCA_StorePath(root, p, q)
  pathP ← FindPath(root, p, EMPTY_LIST)
  pathQ ← FindPath(root, q, EMPTY_LIST)

  lca ← NULL
  FOR i = 0 TO MIN(pathP.SIZE, pathQ.SIZE) - 1 DO
    IF pathP[i] == pathQ[i] THEN
      lca ← pathP[i]
    ELSE
      BREAK
    END IF
  END FOR

  RETURN lca
END FUNCTION

FUNCTION FindPath(node, target, path)
  IF node == NULL THEN
    RETURN FALSE
  END IF

  path.ADD(node)

  IF node.val == target.val THEN
    RETURN TRUE
  END IF

  IF FindPath(node.left, target, path) OR
     FindPath(node.right, target, path) THEN
    RETURN TRUE
  END IF

  path.REMOVE_LAST()
  RETURN FALSE
END FUNCTION
```

**Code Implementation:**
```csharp
public static TreeNode FindLCA_StorePath(TreeNode root, TreeNode p, TreeNode q)
{
    var pathP = new List<TreeNode>();
    var pathQ = new List<TreeNode>();

    FindPath(root, p, pathP);
    FindPath(root, q, pathQ);

    TreeNode lca = null;
    int minLen = Math.Min(pathP.Count, pathQ.Count);

    for (int i = 0; i < minLen; i++)
    {
        if (pathP[i].val == pathQ[i].val)
            lca = pathP[i];
        else
            break;
    }

    return lca;
}

private static bool FindPath(TreeNode node, TreeNode target, List<TreeNode> path)
{
    if (node == null) return false;

    path.Add(node);

    if (node.val == target.val) return true;

    if (FindPath(node.left, target, path) || FindPath(node.right, target, path))
        return true;

    path.RemoveAt(path.Count - 1);
    return false;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

#### 63.2 [Optimized - Single Pass]

**Pseudocode:**
```
FUNCTION FindLCA_SinglePass(node, p, q)
  IF node == NULL THEN
    RETURN NULL
  END IF

  IF node.val == p.val OR node.val == q.val THEN
    RETURN node
  END IF

  leftLCA ← FindLCA_SinglePass(node.left, p, q)
  rightLCA ← FindLCA_SinglePass(node.right, p, q)

  IF leftLCA != NULL AND rightLCA != NULL THEN
    RETURN node
  END IF

  RETURN leftLCA != NULL ? leftLCA : rightLCA
END FUNCTION
```

**Code Implementation:**
```csharp
public static TreeNode FindLCA_SinglePass(TreeNode node, TreeNode p, TreeNode q)
{
    if (node == null) return null;

    if (node.val == p.val || node.val == q.val)
        return node;

    TreeNode leftLCA = FindLCA_SinglePass(node.left, p, q);
    TreeNode rightLCA = FindLCA_SinglePass(node.right, p, q);

    if (leftLCA != null && rightLCA != null)
        return node;

    return leftLCA ?? rightLCA;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

---

### 64. Maximum Path Sum in Binary Tree

#### Constraints
- Tree root may be null
- Path may include any nodes (not necessarily root to leaf)
- Return maximum sum of any path
- Nodes can have negative values

**Pseudocode:**
```
FUNCTION MaxPathSum(node, maxSum_ref)
  IF node == NULL THEN
    RETURN 0
  END IF

  leftMax ← MAX(0, MaxPathSum(node.left, maxSum_ref))
  rightMax ← MAX(0, MaxPathSum(node.right, maxSum_ref))

  pathSum ← node.val + leftMax + rightMax
  maxSum_ref.value ← MAX(maxSum_ref.value, pathSum)

  RETURN node.val + MAX(leftMax, rightMax)
END FUNCTION
```

**Code Implementation:**
```csharp
public static int MaxPathSum(TreeNode root)
{
    int[] maxSum = { int.MinValue };
    MaxPathSumHelper(root, maxSum);
    return maxSum[0];
}

private static int MaxPathSumHelper(TreeNode node, int[] maxSum)
{
    if (node == null) return 0;

    int leftMax = Math.Max(0, MaxPathSumHelper(node.left, maxSum));
    int rightMax = Math.Max(0, MaxPathSumHelper(node.right, maxSum));

    int pathSum = node.val + leftMax + rightMax;
    maxSum[0] = Math.Max(maxSum[0], pathSum);

    return node.val + Math.Max(leftMax, rightMax);
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

---

### 65. Serialize and Deserialize Tree

#### Constraints
- Tree can be null (leaf position)
- Serialize to string format
- Deserialize back to identical tree
- Use pre-order or BFS traversal

**Pseudocode (DFS approach):**
```
FUNCTION Serialize(node, result)
  IF node == NULL THEN
    result.ADD("null")
    RETURN
  END IF

  result.ADD(node.val)
  Serialize(node.left, result)
  Serialize(node.right, result)
END FUNCTION

FUNCTION Deserialize(data, index_ref)
  val ← data[index_ref.value]
  index_ref.value ← index_ref.value + 1

  IF val == "null" THEN
    RETURN NULL
  END IF

  node ← NEW TreeNode(INT(val))
  node.left ← Deserialize(data, index_ref)
  node.right ← Deserialize(data, index_ref)
  RETURN node
END FUNCTION
```

**Code Implementation:**
```csharp
public class Codec
{
    public string Serialize(TreeNode root)
    {
        var result = new List<string>();
        SerializeHelper(root, result);
        return string.Join(",", result);
    }

    private void SerializeHelper(TreeNode node, List<string> result)
    {
        if (node == null)
        {
            result.Add("null");
            return;
        }

        result.Add(node.val.ToString());
        SerializeHelper(node.left, result);
        SerializeHelper(node.right, result);
    }

    public TreeNode Deserialize(string data)
    {
        var values = data.Split(',').ToList();
        return DeserializeHelper(values, new int[] { 0 });
    }

    private TreeNode DeserializeHelper(List<string> values, int[] index)
    {
        if (index[0] >= values.Count || values[index[0]] == "null")
        {
            index[0]++;
            return null;
        }

        TreeNode node = new TreeNode(int.Parse(values[index[0]]));
        index[0]++;

        node.left = DeserializeHelper(values, index);
        node.right = DeserializeHelper(values, index);

        return node;
    }
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

---

### 66. Balanced Binary Tree Check

#### Constraints
- Tree root may be null
- Balanced: height difference of left/right <= 1
- Check balance recursively for all nodes
- Return true if balanced, false otherwise

**Pseudocode:**
```
FUNCTION IsBalanced(node)
  RETURN GetHeight(node) != -1
END FUNCTION

FUNCTION GetHeight(node)
  IF node == NULL THEN
    RETURN 0
  END IF

  leftHeight ← GetHeight(node.left)
  IF leftHeight == -1 THEN
    RETURN -1  // Left subtree not balanced
  END IF

  rightHeight ← GetHeight(node.right)
  IF rightHeight == -1 THEN
    RETURN -1  // Right subtree not balanced
  END IF

  IF ABS(leftHeight - rightHeight) > 1 THEN
    RETURN -1  // Current node not balanced
  END IF

  RETURN MAX(leftHeight, rightHeight) + 1
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool IsBalanced(TreeNode root)
{
    return GetHeight(root) != -1;
}

private static int GetHeight(TreeNode node)
{
    if (node == null) return 0;

    int leftHeight = GetHeight(node.left);
    if (leftHeight == -1) return -1;

    int rightHeight = GetHeight(node.right);
    if (rightHeight == -1) return -1;

    if (Math.Abs(leftHeight - rightHeight) > 1)
        return -1;

    return Math.Max(leftHeight, rightHeight) + 1;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(h)`

---

## Level 11: Graph (Network & Relationship Modeling)

> `Traversal & Path Finding techniques`

### 67. Graph Traversals (DFS, BFS)

#### 67.1 [Brute Force - DFS Recursive]

**Pseudocode:**
```
FUNCTION DFSRecursive(node, visited)
  visited.ADD(node)
  PRINT node

  FOR each neighbor IN node.neighbors DO
    IF neighbor NOT IN visited THEN
      DFSRecursive(neighbor, visited)
    END IF
  END FOR
END FUNCTION
```

**Code Implementation:**
```csharp
public static void DFSRecursive(int node, List<List<int>> graph, HashSet<int> visited)
{
    visited.Add(node);
    Console.WriteLine(node);

    foreach (int neighbor in graph[node])
    {
        if (!visited.Contains(neighbor))
            DFSRecursive(neighbor, graph, visited);
    }
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)` (Visited set + Call stack)

#### 67.2 [DFS Iterative - Stack]

**Pseudocode:**
```
FUNCTION DFSIterative(start, graph)
  visited ← EMPTY_SET
  stack ← EMPTY_STACK
  stack.PUSH(start)

  WHILE stack NOT EMPTY DO
    node ← stack.POP()
    IF node NOT IN visited THEN
      visited.ADD(node)
      PRINT node

      FOR each neighbor IN node.neighbors DO
        IF neighbor NOT IN visited THEN
          stack.PUSH(neighbor)
        END IF
      END FOR
    END IF
  END WHILE
END FUNCTION
```

**Code Implementation:**
```csharp
public static void DFSIterative(int start, List<List<int>> graph)
{
    var visited = new HashSet<int>();
    var stack = new Stack<int>();
    stack.Push(start);

    while (stack.Count > 0)
    {
        int node = stack.Pop();
        if (!visited.Contains(node))
        {
            visited.Add(node);
            Console.WriteLine(node);

            foreach (int neighbor in graph[node])
            {
                if (!visited.Contains(neighbor))
                    stack.Push(neighbor);
            }
        }
    }
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)`

#### 67.3 [BFS - Queue]

**Pseudocode:**
```
FUNCTION BFS(start, graph)
  visited ← EMPTY_SET
  queue ← EMPTY_QUEUE
  queue.ENQUEUE(start)
  visited.ADD(start)

  WHILE queue NOT EMPTY DO
    node ← queue.DEQUEUE()
    PRINT node

    FOR each neighbor IN node.neighbors DO
      IF neighbor NOT IN visited THEN
        visited.ADD(neighbor)
        queue.ENQUEUE(neighbor)
      END IF
    END FOR
  END WHILE
END FUNCTION
```

**Code Implementation:**
```csharp
public static void BFS(int start, List<List<int>> graph)
{
    var visited = new HashSet<int>();
    var queue = new Queue<int>();
    queue.Enqueue(start);
    visited.Add(start);

    while (queue.Count > 0)
    {
        int node = queue.Dequeue();
        Console.WriteLine(node);

        foreach (int neighbor in graph[node])
        {
            if (!visited.Contains(neighbor))
            {
                visited.Add(neighbor);
                queue.Enqueue(neighbor);
            }
        }
    }
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)`

---

### 68. Detect Cycle in Graph

#### 68.1 [Brute Force - DFS]

**Pseudocode:**
```
FUNCTION HasCycleDFS(node, visited, recStack, graph)
  visited.ADD(node)
  recStack.ADD(node)

  FOR each neighbor IN graph[node] DO
    IF neighbor NOT IN visited THEN
      IF HasCycleDFS(neighbor, visited, recStack, graph) THEN
        RETURN TRUE
      END IF
    ELSE IF neighbor IN recStack THEN
      RETURN TRUE  // Back edge = cycle
    END IF
  END FOR

  recStack.REMOVE(node)
  RETURN FALSE
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool HasCycleDFS(int node, HashSet<int> visited, HashSet<int> recStack, List<List<int>> graph)
{
    visited.Add(node);
    recStack.Add(node);

    foreach (int neighbor in graph[node])
    {
        if (!visited.Contains(neighbor))
        {
            if (HasCycleDFS(neighbor, visited, recStack, graph))
                return true;
        }
        else if (recStack.Contains(neighbor))
            return true;  // Back edge
    }

    recStack.Remove(node);
    return false;
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)`

#### 68.2 [Union-Find (Disjoint Set)]

**Pseudocode:**
```
FUNCTION HasCycleUnionFind(edges, n)
  parent ← [0, 1, 2, ..., n-1]

  FOR each edge (u, v) IN edges DO
    rootU ← Find(u, parent)
    rootV ← Find(v, parent)

    IF rootU == rootV THEN
      RETURN TRUE  // Cycle detected
    END IF

    Union(rootU, rootV, parent)
  END FOR

  RETURN FALSE
END FUNCTION

FUNCTION Find(x, parent)
  IF parent[x] != x THEN
    parent[x] ← Find(parent[x], parent)  // Path compression
  END IF
  RETURN parent[x]
END FUNCTION

FUNCTION Union(x, y, parent)
  parent[y] ← x
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool HasCycleUnionFind(int[][] edges, int n)
{
    int[] parent = new int[n];
    for (int i = 0; i < n; i++) parent[i] = i;

    foreach (int[] edge in edges)
    {
        int rootU = Find(edge[0], parent);
        int rootV = Find(edge[1], parent);

        if (rootU == rootV) return true;

        parent[rootV] = rootU;
    }

    return false;
}

private static int Find(int x, int[] parent)
{
    if (parent[x] != x)
        parent[x] = Find(parent[x], parent);
    return parent[x];
}
```

- **Time Complexity :** `O((V + E) * α(V))` (α = inverse Ackermann)
- **Space Complexity :** `O(V)`

---

### 69. Topological Sort

#### 69.1 [Brute Force - DFS]

**Pseudocode:**
```
FUNCTION TopologicalSortDFS(graph)
  visited ← EMPTY_SET
  stack ← EMPTY_STACK

  FOR each node = 0 TO graph.length - 1 DO
    IF node NOT IN visited THEN
      TopologicalDFSUtil(node, visited, stack, graph)
    END IF
  END FOR

  result ← EMPTY_LIST
  WHILE stack NOT EMPTY DO
    result.ADD(stack.POP())
  END WHILE

  RETURN result
END FUNCTION

FUNCTION TopologicalDFSUtil(node, visited, stack, graph)
  visited.ADD(node)

  FOR each neighbor IN graph[node] DO
    IF neighbor NOT IN visited THEN
      TopologicalDFSUtil(neighbor, visited, stack, graph)
    END IF
  END FOR

  stack.PUSH(node)
END FUNCTION
```

**Code Implementation:**
```csharp
public static List<int> TopologicalSortDFS(List<List<int>> graph)
{
    var visited = new HashSet<int>();
    var stack = new Stack<int>();

    for (int i = 0; i < graph.Count; i++)
    {
        if (!visited.Contains(i))
            TopologicalDFSUtil(i, visited, stack, graph);
    }

    var result = new List<int>();
    while (stack.Count > 0)
        result.Add(stack.Pop());

    return result;
}

private static void TopologicalDFSUtil(int node, HashSet<int> visited, Stack<int> stack, List<List<int>> graph)
{
    visited.Add(node);

    foreach (int neighbor in graph[node])
    {
        if (!visited.Contains(neighbor))
            TopologicalDFSUtil(neighbor, visited, stack, graph);
    }

    stack.Push(node);
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)`

#### 69.2 [Kahn's Algorithm - BFS]

**Pseudocode:**
```
FUNCTION TopologicalSortKahn(graph, n)
  inDegree ← [0, 0, ..., 0] (size n)

  FOR each node = 0 TO n - 1 DO
    FOR each neighbor IN graph[node] DO
      inDegree[neighbor]++
    END FOR
  END FOR

  queue ← EMPTY_QUEUE
  FOR each node = 0 TO n - 1 DO
    IF inDegree[node] == 0 THEN
      queue.ENQUEUE(node)
    END IF
  END FOR

  result ← EMPTY_LIST
  WHILE queue NOT EMPTY DO
    node ← queue.DEQUEUE()
    result.ADD(node)

    FOR each neighbor IN graph[node] DO
      inDegree[neighbor]--
      IF inDegree[neighbor] == 0 THEN
        queue.ENQUEUE(neighbor)
      END IF
    END FOR
  END WHILE

  RETURN result
END FUNCTION
```

**Code Implementation:**
```csharp
public static List<int> TopologicalSortKahn(List<List<int>> graph, int n)
{
    int[] inDegree = new int[n];

    for (int i = 0; i < n; i++)
    {
        foreach (int neighbor in graph[i])
            inDegree[neighbor]++;
    }

    var queue = new Queue<int>();
    for (int i = 0; i < n; i++)
    {
        if (inDegree[i] == 0)
            queue.Enqueue(i);
    }

    var result = new List<int>();
    while (queue.Count > 0)
    {
        int node = queue.Dequeue();
        result.Add(node);

        foreach (int neighbor in graph[node])
        {
            inDegree[neighbor]--;
            if (inDegree[neighbor] == 0)
                queue.Enqueue(neighbor);
        }
    }

    return result;
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)`

---

### 70. Shortest Path (Dijkstra)

#### 70.1 [Brute Force - Bellman-Ford]

**Pseudocode:**
```
FUNCTION BellmanFord(graph, src, n)
  dist ← [INF, INF, ..., INF] (size n)
  dist[src] ← 0

  // Relax edges n-1 times
  FOR i = 0 TO n - 2 DO
    FOR each edge (u, v, w) IN graph DO
      IF dist[u] + w < dist[v] THEN
        dist[v] ← dist[u] + w
      END IF
    END FOR
  END FOR

  // Check for negative cycles
  FOR each edge (u, v, w) IN graph DO
    IF dist[u] + w < dist[v] THEN
      RETURN "Negative cycle exists"
    END IF
  END FOR

  RETURN dist
END FUNCTION
```

**Code Implementation:**
```csharp
public static int[] BellmanFord(int n, int[][] edges, int src)
{
    int[] dist = new int[n];
    for (int i = 0; i < n; i++) dist[i] = int.MaxValue;
    dist[src] = 0;

    for (int i = 0; i < n - 1; i++)
    {
        foreach (int[] edge in edges)
        {
            int u = edge[0], v = edge[1], w = edge[2];
            if (dist[u] != int.MaxValue && dist[u] + w < dist[v])
                dist[v] = dist[u] + w;
        }
    }

    return dist;
}
```

- **Time Complexity :** `O(V * E)`
- **Space Complexity :** `O(V)`

#### 70.2 [Optimized - Dijkstra with Priority Queue]

**Pseudocode:**
```
FUNCTION Dijkstra(graph, src, n)
  dist ← [INF, INF, ..., INF] (size n)
  dist[src] ← 0
  pq ← PRIORITY_QUEUE()
  pq.ADD((0, src))

  WHILE pq NOT EMPTY DO
    (d, u) ← pq.EXTRACT_MIN()

    IF d > dist[u] THEN
      CONTINUE  // Already processed
    END IF

    FOR each (v, w) IN graph[u] DO
      IF dist[u] + w < dist[v] THEN
        dist[v] ← dist[u] + w
        pq.ADD((dist[v], v))
      END IF
    END FOR
  END WHILE

  RETURN dist
END FUNCTION
```

**Code Implementation:**
```csharp
public static int[] Dijkstra(List<List<(int, int)>> graph, int src, int n)
{
    int[] dist = new int[n];
    for (int i = 0; i < n; i++) dist[i] = int.MaxValue;
    dist[src] = 0;

    var pq = new PriorityQueue<(int, int), int>();
    pq.Enqueue((src, 0), 0);

    while (pq.Count > 0)
    {
        var (d, u) = pq.Dequeue();

        if (d > dist[u]) continue;

        foreach (var (v, w) in graph[u])
        {
            if (dist[u] + w < dist[v])
            {
                dist[v] = dist[u] + w;
                pq.Enqueue((v, dist[v]), dist[v]);
            }
        }
    }

    return dist;
}
```

- **Time Complexity :** `O((V + E) log V)`
- **Space Complexity :** `O(V)`

---

### 71. Minimum Spanning Tree

#### 71.1 [Kruskal's Algorithm]

**Pseudocode:**
```
FUNCTION Kruskal(edges, n)
  // Sort edges by weight
  Sort(edges by weight)

  parent ← [0, 1, 2, ..., n-1]
  mst ← EMPTY_LIST
  totalWeight ← 0

  FOR each edge (u, v, w) IN edges DO
    rootU ← Find(u, parent)
    rootV ← Find(v, parent)

    IF rootU != rootV THEN
      mst.ADD((u, v, w))
      totalWeight ← totalWeight + w
      Union(rootU, rootV, parent)
    END IF
  END FOR

  RETURN mst
END FUNCTION
```

**Code Implementation:**
```csharp
public static List<(int, int, int)> Kruskal(List<(int, int, int)> edges, int n)
{
    edges.Sort((a, b) => a.Item3.CompareTo(b.Item3));

    int[] parent = new int[n];
    for (int i = 0; i < n; i++) parent[i] = i;

    var mst = new List<(int, int, int)>();

    foreach (var (u, v, w) in edges)
    {
        int rootU = Find(u, parent);
        int rootV = Find(v, parent);

        if (rootU != rootV)
        {
            mst.Add((u, v, w));
            parent[rootV] = rootU;
        }
    }

    return mst;
}
```

- **Time Complexity :** `O(E log E)`
- **Space Complexity :** `O(V)`

#### 71.2 [Prim's Algorithm]

**Pseudocode:**
```
FUNCTION Prim(graph, src, n)
  inMST ← [FALSE, FALSE, ..., FALSE] (size n)
  key ← [INF, INF, ..., INF] (size n)
  key[src] ← 0

  mst ← EMPTY_LIST

  FOR count = 0 TO n - 1 DO
    // Find minimum key vertex not in MST
    u ← FindMinKey(key, inMST)
    inMST[u] ← TRUE

    // Update keys of adjacent vertices
    FOR each neighbor IN graph[u] DO
      weight ← EdgeWeight(u, neighbor)
      IF NOT inMST[neighbor] AND weight < key[neighbor] THEN
        key[neighbor] ← weight
        mst.ADD((u, neighbor, weight))
      END IF
    END FOR
  END FOR

  RETURN mst
END FUNCTION
```

**Code Implementation:**
```csharp
public static List<(int, int)> Prim(List<List<(int, int)>> graph, int n)
{
    bool[] inMST = new bool[n];
    int[] key = new int[n];
    for (int i = 0; i < n; i++) key[i] = int.MaxValue;
    key[0] = 0;

    var mst = new List<(int, int)>();

    for (int count = 0; count < n; count++)
    {
        int u = -1;
        for (int i = 0; i < n; i++)
        {
            if (!inMST[i] && (u == -1 || key[i] < key[u]))
                u = i;
        }

        inMST[u] = true;

        foreach (var (v, w) in graph[u])
        {
            if (!inMST[v] && w < key[v])
            {
                key[v] = w;
                mst.Add((u, v));
            }
        }
    }

    return mst;
}
```

- **Time Complexity :** `O(V²)` or `O((V + E) log V)` with priority queue
- **Space Complexity :** `O(V)`

---

### 72. Word Ladder / Connected Components

#### Constraints
- Both strings and list are not null
- Words have same length
- Transformation changes one letter at a time
- All intermediate words must be in word list
- BFS approach for shortest path

**Pseudocode (Connected Components):**
```
FUNCTION CountConnectedComponents(graph, n)
  visited ← EMPTY_SET
  count ← 0

  FOR node = 0 TO n - 1 DO
    IF node NOT IN visited THEN
      DFS(node, visited, graph)
      count++
    END IF
  END FOR

  RETURN count
END FUNCTION

FUNCTION DFS(node, visited, graph)
  visited.ADD(node)

  FOR each neighbor IN graph[node] DO
    IF neighbor NOT IN visited THEN
      DFS(neighbor, visited, graph)
    END IF
  END FOR
END FUNCTION
```

**Code Implementation:**
```csharp
public static int CountConnectedComponents(int n, int[][] edges)
{
    var graph = new List<List<int>>[n];
    for (int i = 0; i < n; i++)
        graph[i] = new List<int>();

    foreach (int[] edge in edges)
    {
        graph[edge[0]].Add(edge[1]);
        graph[edge[1]].Add(edge[0]);
    }

    var visited = new HashSet<int>();
    int count = 0;

    for (int i = 0; i < n; i++)
    {
        if (!visited.Contains(i))
        {
            DFS(i, visited, graph);
            count++;
        }
    }

    return count;
}

private static void DFS(int node, HashSet<int> visited, List<int>[] graph)
{
    visited.Add(node);

    foreach (int neighbor in graph[node])
    {
        if (!visited.Contains(neighbor))
            DFS(neighbor, visited, graph);
    }
}
```

- **Time Complexity :** `O(V + E)`
- **Space Complexity :** `O(V)`

---

### 73. Rotting Oranges (2D Matrix BFS)

#### Constraints
- Grid contains three values: 0 (empty), 1 (fresh), 2 (rotten)
- Rotten orange spreads to adjacent fresh oranges each minute
- Find minutes until all oranges rot or return -1 if impossible
- Adjacent means up/down/left/right (not diagonal)

In a given grid, each cell can have one of three values:
- 0: empty cell
- 1: fresh orange
- 2: rotten orange

Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten. Return the minimum number of minutes until no fresh oranges remain (or -1 if impossible).

**Constraints:**
- Oranges rot in 4 directions: up, down, left, right
- All rotten oranges rot simultaneously each minute
- Cannot rot diagonally

```
Example:
[2, 1, 1]
[1, 1, 0]
[0, 1, 1]

Minute 0: Rotten at [0,0]
Minute 1: [0,1], [1,0] become rotten
Minute 2: [1,1] becomes rotten
Minute 3: [1,2], [2,1] become rotten
Minute 4: [2,2] becomes rotten

Answer: 4 minutes
```

```csharp
public static int OrangesRotting(int[][] grid)
{
    int rows = grid.Length;
    int cols = grid[0].Length;

    var queue = new Queue<(int, int, int)>(); // (row, col, time)
    int freshCount = 0;

    // Find all rotten oranges and count fresh ones
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (grid[i][j] == 2)
            {
                queue.Enqueue((i, j, 0));
            }
            else if (grid[i][j] == 1)
            {
                freshCount++;
            }
        }
    }

    // If no fresh oranges, return 0
    if (freshCount == 0) return 0;

    // BFS to rot adjacent oranges
    int[][] directions = { new[] { -1, 0 }, new[] { 1, 0 },
                          new[] { 0, -1 }, new[] { 0, 1 } };
    int maxTime = 0;

    while (queue.Count > 0)
    {
        var (row, col, time) = queue.Dequeue();
        maxTime = Math.Max(maxTime, time);

        // Check all 4 directions
        foreach (var dir in directions)
        {
            int newRow = row + dir[0];
            int newCol = col + dir[1];

            // If within bounds and fresh, rot it
            if (newRow >= 0 && newRow < rows &&
                newCol >= 0 && newCol < cols &&
                grid[newRow][newCol] == 1)
            {
                grid[newRow][newCol] = 2;
                queue.Enqueue((newRow, newCol, time + 1));
                freshCount--;
            }
        }
    }

    // If fresh oranges remain, return -1
    return freshCount == 0 ? maxTime : -1;
}
```

```
Grid:
[2, 1, 1]
[1, 1, 0]
[0, 1, 1]

BFS Timeline:
T=0: Queue = [(0,0)]
     Rot neighbors: (0,1), (1,0)

T=1: Queue = [(0,1), (1,0)]
     From (0,1): Rot (0,2), (1,1)
     From (1,0): Rot (1,1) [already rotting]

T=2: Queue = [(0,2), (1,1)]
     From (0,2): No fresh neighbors
     From (1,1): Rot (1,2), (2,1)

T=3: Queue = [(1,2), (2,1)]
     From (1,2): No fresh neighbors
     From (2,1): Rot (2,2)

T=4: Queue = [(2,2)]
     From (2,2): No fresh neighbors

freshCount = 0 → Return 4
```

- **Time Complexity :** `O(m × n)`
    - Each cell visited once during BFS
- **Space Complexity :** `O(m × n)`
    - Queue can contain up to all cells

---

## Level 12: Dynamic Programming (Optimization Strategy)

> `Memoization & Tabulation techniques`

### 70. Longest Common Subsequence (LCS)

#### 70.1 [Brute Force - Recursive]

**Pseudocode:**
```
FUNCTION LCS_Recursive(s1, s2, i, j)
  IF i == 0 OR j == 0 THEN
    RETURN 0
  END IF

  IF s1[i-1] == s2[j-1] THEN
    RETURN 1 + LCS_Recursive(s1, s2, i-1, j-1)
  ELSE
    RETURN MAX(
      LCS_Recursive(s1, s2, i-1, j),
      LCS_Recursive(s1, s2, i, j-1)
    )
  END IF
END FUNCTION
```

**Code Implementation:**
```csharp
public static int LCS_Recursive(string s1, string s2, int i, int j)
{
    if (i == 0 || j == 0) return 0;

    if (s1[i - 1] == s2[j - 1])
        return 1 + LCS_Recursive(s1, s2, i - 1, j - 1);
    else
        return Math.Max(
            LCS_Recursive(s1, s2, i - 1, j),
            LCS_Recursive(s1, s2, i, j - 1)
        );
}
```

- **Time Complexity :** `O(2ⁿ⁺ᵐ)`
- **Space Complexity :** `O(n + m)` (Call stack)

#### 70.2 [Memoization]

**Pseudocode:**
```
FUNCTION LCS_Memo(s1, s2, i, j, memo)
  IF i == 0 OR j == 0 THEN
    RETURN 0
  END IF

  IF memo[i][j] FOUND THEN
    RETURN memo[i][j]
  END IF

  IF s1[i-1] == s2[j-1] THEN
    result ← 1 + LCS_Memo(s1, s2, i-1, j-1, memo)
  ELSE
    result ← MAX(
      LCS_Memo(s1, s2, i-1, j, memo),
      LCS_Memo(s1, s2, i, j-1, memo)
    )
  END IF

  memo[i][j] ← result
  RETURN result
END FUNCTION
```

**Code Implementation:**
```csharp
public static int LCS_Memo(string s1, string s2, int i, int j, int[,] memo)
{
    if (i == 0 || j == 0) return 0;

    if (memo[i, j] != -1) return memo[i, j];

    int result;
    if (s1[i - 1] == s2[j - 1])
        result = 1 + LCS_Memo(s1, s2, i - 1, j - 1, memo);
    else
        result = Math.Max(
            LCS_Memo(s1, s2, i - 1, j, memo),
            LCS_Memo(s1, s2, i, j - 1, memo)
        );

    memo[i, j] = result;
    return result;
}
```

- **Time Complexity :** `O(n * m)`
- **Space Complexity :** `O(n * m)` (Memo table + Call stack)

#### 70.3 [Tabulation - DP Table]

**Pseudocode:**
```
FUNCTION LCS_Tabulation(s1, s2)
  n ← s1.length
  m ← s2.length
  dp ← [n+1][m+1] initialized to 0

  FOR i = 1 TO n DO
    FOR j = 1 TO m DO
      IF s1[i-1] == s2[j-1] THEN
        dp[i][j] ← dp[i-1][j-1] + 1
      ELSE
        dp[i][j] ← MAX(dp[i-1][j], dp[i][j-1])
      END IF
    END FOR
  END FOR

  RETURN dp[n][m]
END FUNCTION
```

**Code Implementation:**
```csharp
public static int LCS_Tabulation(string s1, string s2)
{
    int n = s1.Length;
    int m = s2.Length;
    int[,] dp = new int[n + 1, m + 1];

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            if (s1[i - 1] == s2[j - 1])
                dp[i, j] = dp[i - 1, j - 1] + 1;
            else
                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
        }
    }

    return dp[n, m];
}
```

- **Time Complexity :** `O(n * m)`
- **Space Complexity :** `O(n * m)`

---

### 71. Longest Increasing Subsequence (LIS)

#### 71.1 [Brute Force - O(2ⁿ)]

**Placeholder for implementation**

- **Time Complexity :** `O(2ⁿ)`
- **Space Complexity :** `O(n)` (Call stack)

#### 71.2 [DP - O(n²)]

**Placeholder for implementation**

- **Time Complexity :** `O(n²)`
- **Space Complexity :** `O(n)`

#### 71.3 [Binary Search Optimized - O(n log n)]

**Placeholder for implementation**

- **Time Complexity :** `O(n log n)`
- **Space Complexity :** `O(n)`

---

### 72. 0/1 Knapsack Problem

#### 72.1 [Brute Force - Exponential]

**Placeholder for implementation**

- **Time Complexity :** `O(2ⁿ)`
- **Space Complexity :** `O(n)`

#### 72.2 [DP Tabulation - O(n*w)]

**Placeholder for implementation**

- **Time Complexity :** `O(n * w)` (n = items, w = weight capacity)
- **Space Complexity :** `O(n * w)`

---

### 73. Coin Change Problem

#### 73.1 [Brute Force - Recursive]

**Placeholder for implementation**

- **Time Complexity :** `O(sum^n)` (sum = target, n = coin types)
- **Space Complexity :** `O(sum)`

#### 73.2 [DP - Minimum Coins]

**Placeholder for implementation**

- **Time Complexity :** `O(sum * n)`
- **Space Complexity :** `O(sum)`

---

### 74. Edit Distance (Levenshtein)

#### 74.1 [Brute Force - Recursive]

**Placeholder for implementation**

- **Time Complexity :** `O(3ⁿ⁺ᵐ)`
- **Space Complexity :** `O(n + m)`

#### 74.2 [DP Tabulation]

**Placeholder for implementation**

- **Time Complexity :** `O(n * m)`
- **Space Complexity :** `O(n * m)`

---

### 75. Matrix Chain Multiplication

#### Constraints
- Multiple matrices to multiply in sequence
- Find optimal order to minimize operations
- Use dynamic programming
- Return minimum scalar multiplications

**Placeholder for implementation**

- **Time Complexity :** `O(n³)`
- **Space Complexity :** `O(n²)`

---

### 76. Unique Paths in Grid

#### Constraints
- m x n grid (start top-left, end bottom-right)
- Move only right or down
- Count total unique paths
- Use dynamic programming or combinatorics

**Placeholder for implementation**

- **Time Complexity :** `O(m * n)`
- **Space Complexity :** `O(m * n)`

---

### 77. Maximum Subarray (Kadane's Algorithm)

#### Constraints
- Array contains both positive and negative integers
- Find maximum sum of contiguous subarray
- Use Kadane's algorithm: O(n) time
- Return maximum sum value

**Placeholder for implementation**

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

---

### 78. Best Time to Buy and Sell Stock

#### Constraints
- Array contains daily stock prices
- Buy on one day, sell on a later day
- Maximize profit (or return 0 if no profit possible)
- O(n) time, O(1) space required

You are given an array `prices` where `prices[i]` is the price of a given stock on the ith day. You want to maximize your profit by choosing a single day to buy one stock and a different day in the future to sell that stock. Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

**Constraints:**
- You may not engage in multiple transactions (buy-sell-buy-sell, etc.)
- You cannot sell before you buy
- You must select both buy and sell days

```
Examples:
Input: prices = [7, 1, 5, 3, 6, 4]
Output: 5
Explanation: Buy on day 2 (price = 1), Sell on day 5 (price = 6). Profit = 6 - 1 = 5

Input: prices = [7, 6, 4, 3, 1]
Output: 0
Explanation: No profit possible since prices are strictly decreasing
```

#### 78.1 [Brute Force - All Pairs]

Compare all possible buy-sell pairs and track the maximum profit.

```csharp
public static int MaxProfitBruteForce(int[] prices)
{
    int maxProfit = 0;

    // Try all possible pairs of (buy day, sell day)
    for (int i = 0; i < prices.Length; i++)
    {
        for (int j = i + 1; j < prices.Length; j++)
        {
            int profit = prices[j] - prices[i];
            maxProfit = Math.Max(maxProfit, profit);
        }
    }

    return maxProfit;
}
```

```text
prices = [7, 1, 5, 3, 6, 4]
Index:    0  1  2  3  4  5

All pairs checked:
(0,1): 1-7 = -6 ✗ (negative)
(0,2): 5-7 = -2 ✗ (negative)
(0,3): 3-7 = -4 ✗ (negative)
(0,4): 6-7 = -1 ✗ (negative)
(0,5): 4-7 = -3 ✗ (negative)
(1,2): 5-1 = 4 ✓
(1,3): 3-1 = 2 ✓
(1,4): 6-1 = 5 ✓ ← Maximum
(1,5): 4-1 = 3 ✓
(2,3): 3-5 = -2 ✗
(2,4): 6-5 = 1 ✓
(2,5): 4-5 = -1 ✗
(3,4): 6-3 = 3 ✓
(3,5): 4-3 = 1 ✓
(4,5): 4-6 = -2 ✗

Maximum profit = 5 (buy at index 1, sell at index 4)
```

- **Time Complexity :** `O(n²)`
    - Nested loops checking all pairs
    - Each pair requires one comparison
- **Space Complexity :** `O(1)`
    - Only tracking maxProfit variable

#### 78.2 [Dynamic Programming - Max Profit with State]

Track the maximum profit at each position while maintaining the minimum price seen so far.

```csharp
public static int MaxProfitDP(int[] prices)
{
    if (prices.Length <= 1) return 0;

    int maxProfit = 0;
    int minPrice = prices[0];  // Minimum price seen so far

    // For each price, calculate profit if we sell at this price
    for (int i = 1; i < prices.Length; i++)
    {
        // Profit if we sell at current price (bought at minPrice)
        int profit = prices[i] - minPrice;

        // Update max profit
        maxProfit = Math.Max(maxProfit, profit);

        // Update minimum price if current price is lower
        minPrice = Math.Min(minPrice, prices[i]);
    }

    return maxProfit;
}
```

```text
prices = [7, 1, 5, 3, 6, 4]

Iteration 1: i=1, prices[1]=1
  profit = 1 - 7 = -6
  maxProfit = max(0, -6) = 0
  minPrice = min(7, 1) = 1

Iteration 2: i=2, prices[2]=5
  profit = 5 - 1 = 4
  maxProfit = max(0, 4) = 4
  minPrice = min(1, 5) = 1

Iteration 3: i=3, prices[3]=3
  profit = 3 - 1 = 2
  maxProfit = max(4, 2) = 4
  minPrice = min(1, 3) = 1

Iteration 4: i=4, prices[4]=6
  profit = 6 - 1 = 5
  maxProfit = max(4, 5) = 5 ✓
  minPrice = min(1, 6) = 1

Iteration 5: i=5, prices[5]=4
  profit = 4 - 1 = 3
  maxProfit = max(5, 3) = 5
  minPrice = min(1, 4) = 1

Return: maxProfit = 5
```

**Key Insight:** We don't need to store all previous states. We only need:
1. The minimum price seen up to current position
2. The maximum profit found so far

Then at each position, profit = current_price - min_price_so_far

- **Time Complexity :** `O(n)`
    - Single pass through prices array
    - Each iteration does constant work
- **Space Complexity :** `O(1)`
    - Only tracking minPrice and maxProfit

#### 78.3 [Greedy - Single Pass Optimal]

A greedy approach that tracks the minimum price and always calculates potential profit. Since we can only do one transaction, we greedily maximize profit at each step.

```csharp
public static int MaxProfitGreedy(int[] prices)
{
    if (prices.Length <= 1) return 0;

    int minPrice = int.MaxValue;
    int maxProfit = 0;

    foreach (int price in prices)
    {
        // Calculate potential profit if we sell at this price
        maxProfit = Math.Max(maxProfit, price - minPrice);

        // Update minimum price for future transactions
        minPrice = Math.Min(minPrice, price);
    }

    return maxProfit;
}
```

```text
prices = [7, 1, 5, 3, 6, 4]

Greedy Strategy: Always keep track of lowest price, always calculate best profit

Step 1: price=7
  maxProfit = max(0, 7 - INF) = 0
  minPrice = min(INF, 7) = 7

Step 2: price=1 (new low found!)
  maxProfit = max(0, 1 - 7) = 0
  minPrice = min(7, 1) = 1

Step 3: price=5
  maxProfit = max(0, 5 - 1) = 4 (profit with current low)
  minPrice = min(1, 5) = 1

Step 4: price=3
  maxProfit = max(4, 3 - 1) = 4
  minPrice = min(1, 3) = 1

Step 5: price=6
  maxProfit = max(4, 6 - 1) = 5 ✓ (best profit found)
  minPrice = min(1, 6) = 1

Step 6: price=4
  maxProfit = max(5, 4 - 1) = 5
  minPrice = min(1, 4) = 1

Return: 5
```

**Greedy Choice:** At each price point, we greedily:
1. Calculate profit if we sell now (at lowest price seen)
2. Update the "sell at current" profit if it's better
3. Move forward, which naturally handles the "buy before sell" constraint

- **Time Complexity :** `O(n)`
    - Single pass with constant operations per element
- **Space Complexity :** `O(1)`
    - Only two variables tracking state

**Comparison Table:**

| Approach | Time | Space | Method |
|----------|------|-------|--------|
| **Brute Force** | O(n²) | O(1) | Check all pairs |
| **Dynamic Programming** | O(n) | O(1) | Track min price + max profit |
| **Greedy** | O(n) | O(1) | Single pass with min tracking |

**Why Greedy Works:** Since we can only do one transaction (buy-sell), and we want maximum profit, the optimal choice is always to sell at the first day we can make a profit (given we bought at the lowest price before it). This greedy choice leads to the global optimum.

---

### 83. Trapping Rain Water (Max Water Container)

#### Constraints
- Array contains elevation heights (non-negative)
- Calculate water trapped after rain
- Water level: MIN(max_left, max_right) - height[i]
- Use two-pointer or pre-computed arrays

Given an elevation map represented by an array of heights, compute how much water can be trapped after raining. Water trapped is determined by the minimum of the maximum heights to the left and right, minus the current height.

```
Example:
Heights: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]

Visualization:
       |
       █
    |  █  |
    █  █  |  █
    █  █  █  █  █
    █  █  █  █  █

Water trapped: 6 units
```

#### 83.1 [Brute Force - Height Pairs]

For each position, find max height to the left and right, then calculate water trapped.

```csharp
public static int TrappingRainWaterBruteForce(int[] height)
{
    int water = 0;

    for (int i = 0; i < height.Length; i++)
    {
        // Find max height to the left
        int leftMax = 0;
        for (int j = 0; j <= i; j++)
        {
            leftMax = Math.Max(leftMax, height[j]);
        }

        // Find max height to the right
        int rightMax = 0;
        for (int j = i; j < height.Length; j++)
        {
            rightMax = Math.Max(rightMax, height[j]);
        }

        // Water trapped at current position
        int waterLevel = Math.Min(leftMax, rightMax) - height[i];
        water += Math.Max(0, waterLevel);
    }

    return water;
}
```

- **Time Complexity :** `O(n³)`
    - For each element: O(n) to find left max + O(n) to find right max
- **Space Complexity :** `O(1)`

#### 83.2 [Two-Pointer Approach]

Use two pointers moving from outside-in. Track left and right maximum as we go.

```csharp
public static int TrappingRainWaterTwoPointer(int[] height)
{
    int water = 0;
    int left = 0, right = height.Length - 1;
    int leftMax = 0, rightMax = 0;

    while (left < right)
    {
        if (height[left] < height[right])
        {
            if (height[left] >= leftMax)
            {
                leftMax = height[left];
            }
            else
            {
                water += leftMax - height[left];
            }
            left++;
        }
        else
        {
            if (height[right] >= rightMax)
            {
                rightMax = height[right];
            }
            else
            {
                water += rightMax - height[right];
            }
            right--;
        }
    }

    return water;
}
```

```
Heights: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]

Left ptr → | Right ptr ←
0: height[0]=0, leftMax=0 → water=0
1: height[1]=1 → leftMax=1 → water=0
2: height[2]=0 → water+=1-0=1 ✓
3: height[3]=2 → leftMax=2 → water=1
4: height[4]=1 → water+=2-1=1 ✓ (water=2)
...continues...
```

- **Time Complexity :** `O(n)`
    - Single pass with two pointers
- **Space Complexity :** `O(1)`

#### 83.3 [Dynamic Programming]

Pre-compute maximum heights to left and right for all positions.

```csharp
public static int TrappingRainWaterDP(int[] height)
{
    if (height.Length == 0) return 0;

    int n = height.Length;
    int[] leftMax = new int[n];
    int[] rightMax = new int[n];

    // Fill leftMax array
    leftMax[0] = height[0];
    for (int i = 1; i < n; i++)
    {
        leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
    }

    // Fill rightMax array
    rightMax[n - 1] = height[n - 1];
    for (int i = n - 2; i >= 0; i--)
    {
        rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
    }

    // Calculate trapped water
    int water = 0;
    for (int i = 0; i < n; i++)
    {
        water += Math.Min(leftMax[i], rightMax[i]) - height[i];
    }

    return water;
}
```

- **Time Complexity :** `O(n)`
    - Three passes: left max, right max, calculate
- **Space Complexity :** `O(n)`
    - Two arrays of size n

**Comparison Table:**

| Approach | Time | Space | Method |
|----------|------|-------|--------|
| **Brute Force** | O(n³) | O(1) | Find left/right max for each |
| **Two-Pointer** | O(n) | O(1) | Track maxes while moving pointers |
| **Dynamic Programming** | O(n) | O(n) | Pre-compute left/right maxes |

**Key Insight:** DP approach trades space for time, making it optimal when we need to calculate once. Two-Pointer is best for space-constrained environments.

---

## Level 13: Greedy Techniques (Local Optimal Choice)

> `Greedy & Optimization techniques`

### 84. Activity Selection Problem

#### Constraints
- Each activity has start and finish time
- Select maximum non-overlapping activities
- Sort by finish time ascending
- Greedy approach: O(n log n) time

Select the maximum number of activities that don't overlap, where each activity has a start and finish time.

#### 84.1 [Brute Force - All Combinations]

**Pseudocode:**
```
FUNCTION SelectActivitiesBruteForce(activities)
  maxCount ← 0
  maxActivities ← EMPTY_LIST

  FUNCTION GenerateCombinations(index, currentSelection, lastFinish)
    IF index == activities.length THEN
      IF currentSelection.size > maxCount THEN
        maxCount ← currentSelection.size
        maxActivities ← COPY(currentSelection)
      END IF
      RETURN
    END IF

    activity ← activities[index]
    // Include current activity if it doesn't overlap
    IF activity.start >= lastFinish THEN
      currentSelection.ADD(activity)
      GenerateCombinations(index + 1, currentSelection, activity.finish)
      currentSelection.REMOVE_LAST()
    END IF

    // Exclude current activity
    GenerateCombinations(index + 1, currentSelection, lastFinish)
  END FUNCTION

  GenerateCombinations(0, EMPTY_LIST, 0)
  RETURN maxActivities
END FUNCTION
```

**Code Implementation:**
```csharp
public class Activity
{
    public int start, finish;
    public Activity(int s, int f) { start = s; finish = f; }
}

public static List<Activity> SelectActivitiesBruteForce(Activity[] activities)
{
    List<Activity> maxActivities = new List<Activity>();
    GenerateCombinations(activities, 0, new List<Activity>(), 0, maxActivities);
    return maxActivities;
}

private static void GenerateCombinations(Activity[] activities, int index,
    List<Activity> currentSelection, int lastFinish, List<Activity> maxActivities)
{
    if (index == activities.Length)
    {
        if (currentSelection.Count > maxActivities.Count)
            maxActivities = new List<Activity>(currentSelection);
        return;
    }

    // Include current activity if no overlap
    if (activities[index].start >= lastFinish)
    {
        currentSelection.Add(activities[index]);
        GenerateCombinations(activities, index + 1, currentSelection,
            activities[index].finish, maxActivities);
        currentSelection.RemoveAt(currentSelection.Count - 1);
    }

    // Exclude current activity
    GenerateCombinations(activities, index + 1, currentSelection, lastFinish, maxActivities);
}
```

- **Time Complexity :** `O(2ⁿ)`
- **Space Complexity :** `O(n)`

#### 84.2 [Greedy - Earliest Finish Time]

**Pseudocode:**
```
FUNCTION SelectActivitiesGreedy(activities)
  // Sort by finish time
  Sort(activities by finish time)

  selected ← EMPTY_LIST
  selected.ADD(activities[0])
  lastFinish ← activities[0].finish

  FOR i = 1 TO activities.length - 1 DO
    IF activities[i].start >= lastFinish THEN
      selected.ADD(activities[i])
      lastFinish ← activities[i].finish
    END IF
  END FOR

  RETURN selected
END FUNCTION
```

**Code Implementation:**
```csharp
public static List<Activity> SelectActivitiesGreedy(Activity[] activities)
{
    // Sort by finish time
    Array.Sort(activities, (a, b) => a.finish.CompareTo(b.finish));

    var selected = new List<Activity> { activities[0] };
    int lastFinish = activities[0].finish;

    for (int i = 1; i < activities.Length; i++)
    {
        if (activities[i].start >= lastFinish)
        {
            selected.Add(activities[i]);
            lastFinish = activities[i].finish;
        }
    }

    return selected;
}
```

- **Time Complexity :** `O(n log n)` (Sorting)
- **Space Complexity :** `O(1)`

---

### 85. Huffman Coding

#### Constraints
- Input: frequency of each character
- Build binary tree with minimum total encoding length
- Assign variable-length codes (frequent = shorter)
- Use min-heap for tree construction

Create a binary tree for data compression by assigning variable-length codes based on character frequencies.

#### 85.1 [Brute Force - All Frequencies]

**Pseudocode:**
```
FUNCTION HuffmanBruteForce(frequencies)
  // Generate all possible binary trees and select best
  FUNCTION GenerateTrees(charList)
    IF charList.size == 1 THEN
      RETURN [CreateLeafNode(charList[0])]
    END IF

    allTrees ← EMPTY_LIST
    FOR i = 0 TO charList.size - 1 DO
      FOR j = i+1 TO charList.size - 1 DO
        subList ← Combine(charList[i], charList[j])
        subtrees ← GenerateTrees(subList)
        allTrees.ADD_ALL(subtrees)
      END FOR
    END FOR

    RETURN allTrees
  END FUNCTION

  allTrees ← GenerateTrees(frequencies)
  // Select tree with minimum encoding length
  RETURN SelectBestTree(allTrees)
END FUNCTION
```

**Code Implementation:**
```csharp
public class HuffmanNode
{
    public char ch;
    public int freq;
    public HuffmanNode left, right;

    public HuffmanNode(char c, int f) { ch = c; freq = f; }
    public HuffmanNode(HuffmanNode l, HuffmanNode r)
    {
        left = l;
        right = r;
        freq = l.freq + r.freq;
    }
}

public static HuffmanNode HuffmanBruteForce(Dictionary<char, int> frequencies)
{
    // Generate all possible trees (simplified version)
    var nodes = frequencies.Select(x => new HuffmanNode(x.Key, x.Value)).ToList();

    while (nodes.Count > 1)
    {
        // For true brute force, would try all combinations
        // Here showing simplified greedy for demonstration
        nodes.Sort((a, b) => a.freq.CompareTo(b.freq));
        HuffmanNode left = nodes[0];
        HuffmanNode right = nodes[1];
        nodes.RemoveRange(0, 2);

        HuffmanNode parent = new HuffmanNode(left, right);
        nodes.Add(parent);
    }

    return nodes[0];
}
```

- **Time Complexity :** `O(2ⁿ)`
- **Space Complexity :** `O(n)`

#### 85.2 [Greedy - Min Heap]

**Pseudocode:**
```
FUNCTION HuffmanCodingGreedy(frequencies)
  minHeap ← EMPTY_MIN_HEAP

  // Insert all characters with their frequencies
  FOR each (char, freq) IN frequencies DO
    minHeap.INSERT(HuffmanNode(char, freq))
  END FOR

  // Build tree bottom-up
  WHILE minHeap.size > 1 DO
    left ← minHeap.EXTRACT_MIN()
    right ← minHeap.EXTRACT_MIN()

    parent ← NEW HuffmanNode()
    parent.left ← left
    parent.right ← right
    parent.freq ← left.freq + right.freq

    minHeap.INSERT(parent)
  END WHILE

  root ← minHeap.EXTRACT_MIN()

  // Generate codes
  codes ← EMPTY_DICTIONARY
  GenerateCodes(root, "", codes)

  RETURN codes
END FUNCTION

FUNCTION GenerateCodes(node, code, codes)
  IF node == NULL THEN RETURN END IF

  IF node is leaf THEN
    codes[node.char] ← code
    RETURN
  END IF

  GenerateCodes(node.left, code + "0", codes)
  GenerateCodes(node.right, code + "1", codes)
END FUNCTION
```

**Code Implementation:**
```csharp
public static Dictionary<char, string> HuffmanCodingGreedy(Dictionary<char, int> frequencies)
{
    var minHeap = new PriorityQueue<HuffmanNode, int>();

    // Insert all characters
    foreach (var kvp in frequencies)
        minHeap.Enqueue(new HuffmanNode(kvp.Key, kvp.Value), kvp.Value);

    // Build tree bottom-up
    while (minHeap.Count > 1)
    {
        HuffmanNode left = minHeap.Dequeue();
        HuffmanNode right = minHeap.Dequeue();

        HuffmanNode parent = new HuffmanNode(left, right);
        minHeap.Enqueue(parent, parent.freq);
    }

    HuffmanNode root = minHeap.Dequeue();

    // Generate codes
    var codes = new Dictionary<char, string>();
    GenerateCodesHelper(root, "", codes);

    return codes;
}

private static void GenerateCodesHelper(HuffmanNode node, string code, Dictionary<char, string> codes)
{
    if (node == null) return;

    if (node.left == null && node.right == null)
        codes[node.ch] = code;
    else
    {
        GenerateCodesHelper(node.left, code + "0", codes);
        GenerateCodesHelper(node.right, code + "1", codes);
    }
}
```

- **Time Complexity :** `O(n log n)`
- **Space Complexity :** `O(n)`

---

### 86. Fractional Knapsack Problem

#### Constraints
- Each item has weight and value
- Capacity constraint: total weight <= W
- Can take fractions of items (unlike 0/1 knapsack)
- Maximize total value
- Greedy: sort by value/weight ratio

Select items (or fractions of items) to maximize value while staying within weight capacity.

#### 86.1 [Brute Force - All Permutations]

**Pseudocode:**
```
FUNCTION FractionalKnapsackBruteForce(items, capacity)
  maxValue ← 0

  FUNCTION TryAllCombinations(index, currentWeight, currentValue)
    IF index == items.length OR currentWeight >= capacity THEN
      maxValue ← MAX(maxValue, currentValue)
      RETURN
    END IF

    item ← items[index]

    // Try including whole item
    IF currentWeight + item.weight <= capacity THEN
      TryAllCombinations(index + 1, currentWeight + item.weight,
                        currentValue + item.value)
    END IF

    // Try including fraction of item
    remainingCapacity ← capacity - currentWeight
    IF remainingCapacity > 0 THEN
      fraction ← MIN(item.weight, remainingCapacity) / item.weight
      TryAllCombinations(index + 1, currentWeight + fraction * item.weight,
                        currentValue + fraction * item.value)
    END IF

    // Exclude item
    TryAllCombinations(index + 1, currentWeight, currentValue)
  END FUNCTION

  TryAllCombinations(0, 0, 0)
  RETURN maxValue
END FUNCTION
```

**Code Implementation:**
```csharp
public class Item
{
    public double weight, value;
    public Item(double w, double v) { weight = w; value = v; }
}

public static double FractionalKnapsackBruteForce(Item[] items, double capacity)
{
    double maxValue = 0;

    void TryAllCombinations(int index, double currentWeight, double currentValue)
    {
        if (index == items.Length || currentWeight >= capacity)
        {
            maxValue = Math.Max(maxValue, currentValue);
            return;
        }

        // Include whole item
        if (currentWeight + items[index].weight <= capacity)
            TryAllCombinations(index + 1, currentWeight + items[index].weight,
                currentValue + items[index].value);

        // Include fraction
        double remainingCapacity = capacity - currentWeight;
        if (remainingCapacity > 0)
        {
            double fraction = Math.Min(items[index].weight, remainingCapacity) / items[index].weight;
            TryAllCombinations(index + 1, currentWeight + fraction * items[index].weight,
                currentValue + fraction * items[index].value);
        }

        // Exclude item
        TryAllCombinations(index + 1, currentWeight, currentValue);
    }

    TryAllCombinations(0, 0, 0);
    return maxValue;
}
```

- **Time Complexity :** `O(n!)`
- **Space Complexity :** `O(n)`

#### 86.2 [Greedy - Value/Weight Ratio]

**Pseudocode:**
```
FUNCTION FractionalKnapsackGreedy(items, capacity)
  // Sort by value/weight ratio in descending order
  Sort(items by ratio = value/weight DESC)

  totalValue ← 0
  remainingCapacity ← capacity

  FOR each item IN items DO
    IF remainingCapacity == 0 THEN
      BREAK
    END IF

    IF item.weight <= remainingCapacity THEN
      // Take whole item
      totalValue ← totalValue + item.value
      remainingCapacity ← remainingCapacity - item.weight
    ELSE
      // Take fraction of item
      fraction ← remainingCapacity / item.weight
      totalValue ← totalValue + fraction * item.value
      remainingCapacity ← 0
    END IF
  END FOR

  RETURN totalValue
END FUNCTION
```

**Code Implementation:**
```csharp
public static double FractionalKnapsackGreedy(Item[] items, double capacity)
{
    // Sort by value/weight ratio
    Array.Sort(items, (a, b) =>
        (b.value / b.weight).CompareTo(a.value / a.weight));

    double totalValue = 0;
    double remainingCapacity = capacity;

    foreach (Item item in items)
    {
        if (remainingCapacity == 0) break;

        if (item.weight <= remainingCapacity)
        {
            totalValue += item.value;
            remainingCapacity -= item.weight;
        }
        else
        {
            double fraction = remainingCapacity / item.weight;
            totalValue += fraction * item.value;
            remainingCapacity = 0;
        }
    }

    return totalValue;
}
```

- **Time Complexity :** `O(n log n)` (Sorting)
- **Space Complexity :** `O(1)`

---

### 87. Jump Game / Reach End of Array

#### Constraints
- Each element = maximum jump length from that position
- Determine if last index is reachable
- Start from index 0
- Greedy: track maximum reachable index

Determine if you can reach the last index of an array, where each element indicates the maximum jump length.

#### 87.1 [Brute Force - BFS/DFS]

**Pseudocode:**
```
FUNCTION CanJumpBFS(nums)
  IF nums.length <= 1 THEN
    RETURN TRUE
  END IF

  visited ← SET()
  queue ← QUEUE()
  queue.ENQUEUE(0)
  visited.ADD(0)

  WHILE queue NOT EMPTY DO
    index ← queue.DEQUEUE()
    maxJump ← nums[index]

    FOR jump = 1 TO maxJump DO
      nextIndex ← index + jump

      IF nextIndex == nums.length - 1 THEN
        RETURN TRUE
      END IF

      IF nextIndex < nums.length AND nextIndex NOT IN visited THEN
        visited.ADD(nextIndex)
        queue.ENQUEUE(nextIndex)
      END IF
    END FOR
  END WHILE

  RETURN FALSE
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool CanJumpBFS(int[] nums)
{
    if (nums.Length <= 1) return true;

    var visited = new HashSet<int>();
    var queue = new Queue<int>();
    queue.Enqueue(0);
    visited.Add(0);

    while (queue.Count > 0)
    {
        int index = queue.Dequeue();
        int maxJump = nums[index];

        for (int jump = 1; jump <= maxJump; jump++)
        {
            int nextIndex = index + jump;

            if (nextIndex == nums.Length - 1)
                return true;

            if (nextIndex < nums.Length && !visited.Contains(nextIndex))
            {
                visited.Add(nextIndex);
                queue.Enqueue(nextIndex);
            }
        }
    }

    return false;
}
```

- **Time Complexity :** `O(2ⁿ)` or `O(n²)` with optimization
- **Space Complexity :** `O(n)`

#### 87.2 [Greedy - Maximum Reach]

**Pseudocode:**
```
FUNCTION CanJumpGreedy(nums)
  maxReach ← 0

  FOR i = 0 TO nums.length - 1 DO
    IF i > maxReach THEN
      RETURN FALSE  // Can't reach this index
    END IF

    IF i == nums.length - 1 THEN
      RETURN TRUE  // Reached the end
    END IF

    maxReach ← MAX(maxReach, i + nums[i])
  END FOR

  RETURN TRUE
END FUNCTION
```

**Code Implementation:**
```csharp
public static bool CanJumpGreedy(int[] nums)
{
    int maxReach = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (i > maxReach)
            return false;  // Can't reach this index

        if (i == nums.Length - 1)
            return true;  // Reached the end

        maxReach = Math.Max(maxReach, i + nums[i]);
    }

    return true;
}
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

---

### 88. Interval Scheduling Maximization

#### Constraints
- List of intervals (start, end)
- Maximize number of non-overlapping intervals
- Sort by end time ascending
- Greedy selection

Given a list of intervals, find the maximum number of non-overlapping intervals.

**Pseudocode:**
```
FUNCTION MaximizeIntervals(intervals)
  IF intervals.length == 0 THEN
    RETURN 0
  END IF

  // Sort by end time
  Sort(intervals by end time ASC)

  count ← 1
  lastEnd ← intervals[0].end

  FOR i = 1 TO intervals.length - 1 DO
    IF intervals[i].start >= lastEnd THEN
      count ← count + 1
      lastEnd ← intervals[i].end
    END IF
  END FOR

  RETURN count
END FUNCTION
```

**Code Implementation:**
```csharp
public class Interval
{
    public int start, end;
    public Interval(int s, int e) { start = s; end = e; }
}

public static int MaximizeIntervals(Interval[] intervals)
{
    if (intervals.Length == 0) return 0;

    // Sort by end time
    Array.Sort(intervals, (a, b) => a.end.CompareTo(b.end));

    int count = 1;
    int lastEnd = intervals[0].end;

    for (int i = 1; i < intervals.Length; i++)
    {
        if (intervals[i].start >= lastEnd)
        {
            count++;
            lastEnd = intervals[i].end;
        }
    }

    return count;
}
```

- **Time Complexity :** `O(n log n)`
- **Space Complexity :** `O(1)`

---

### 89. Gas Station / Circuit

#### Constraints
- Each station has gas amount and cost to next station
- Circular route: visit all stations and return
- Single tank, refuel at each station
- Find starting station or return -1 if impossible

Start at a gas station and visit all stations in a circular route. Each station has gas to consume and distance to next station.

**Pseudocode:**
```
FUNCTION CanCompleteCircuit(gas, cost)
  totalGas ← SUM(gas)
  totalCost ← SUM(cost)

  // If total gas < total cost, impossible to complete
  IF totalGas < totalCost THEN
    RETURN -1
  END IF

  currentGas ← 0
  startIndex ← 0

  FOR i = 0 TO gas.length - 1 DO
    currentGas ← currentGas + gas[i] - cost[i]

    IF currentGas < 0 THEN
      // Can't reach station i+1 from startIndex
      // Start from i+1
      startIndex ← i + 1
      currentGas ← 0
    END IF
  END FOR

  RETURN startIndex
END FUNCTION
```

**Logic:**
- If total gas >= total cost, a solution always exists
- When gas becomes negative at index i, we can't start from any index ≤ i
- Start from i+1 instead

**Code Implementation:**
```csharp
public static int CanCompleteCircuit(int[] gas, int[] cost)
{
    int totalGas = 0, totalCost = 0;
    foreach (int g in gas) totalGas += g;
    foreach (int c in cost) totalCost += c;

    // If total gas < total cost, impossible
    if (totalGas < totalCost) return -1;

    int currentGas = 0;
    int startIndex = 0;

    for (int i = 0; i < gas.Length; i++)
    {
        currentGas += gas[i] - cost[i];

        // Can't reach next station from startIndex
        if (currentGas < 0)
        {
            startIndex = i + 1;
            currentGas = 0;
        }
    }

    return startIndex;
}
```

```text
Example: gas = [1,2,3,4,5], cost = [3,4,5,1,2]
Index:   0  1  2  3  4

i=0: gas=1, cost=3, currentGas=-2 → start=1, currentGas=0
i=1: gas=2, cost=4, currentGas=-2 → start=2, currentGas=0
i=2: gas=3, cost=5, currentGas=-2 → start=3, currentGas=0
i=3: gas=4, cost=1, currentGas=3 ✓
i=4: gas=5, cost=2, currentGas=6 ✓

Return: 3 ✓
```

- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

---

### 90. Candy Distribution Problem

#### Constraints
- Each child gets minimum 1 candy
- Higher rating than neighbor => more candy than neighbor
- Minimize total candy distributed
- Two-pass algorithm: left-to-right, then right-to-left

Distribute candy to children where each child must get at least 1 candy, and children with higher ratings than neighbors must get more candy than those neighbors.

**Pseudocode:**
```
FUNCTION DistributeCandy(ratings)
  n ← ratings.length
  candy ← ARRAY of size n, initialize all to 1

  // Left to right pass: if rating[i] > rating[i-1],
  // then candy[i] = candy[i-1] + 1
  FOR i = 1 TO n - 1 DO
    IF ratings[i] > ratings[i-1] THEN
      candy[i] ← candy[i-1] + 1
    END IF
  END FOR

  // Right to left pass: ensure candy[i] > candy[i+1]
  // if ratings[i] > ratings[i+1]
  FOR i = n - 2 DOWN TO 0 DO
    IF ratings[i] > ratings[i+1] THEN
      candy[i] ← MAX(candy[i], candy[i+1] + 1)
    END IF
  END FOR

  RETURN SUM(candy)
END FUNCTION
```

**Logic:**
- Two passes approach:
  1. Left→Right: ensure candy increases with ascending ratings
  2. Right→Left: ensure candy satisfies descending ratings constraint
- Each child gets minimum 1 candy initially
- Both constraints must be satisfied simultaneously

**Code Implementation:**
```csharp
public static int DistributeCandy(int[] ratings)
{
    int n = ratings.Length;
    int[] candy = new int[n];

    // Initialize all children with 1 candy
    for (int i = 0; i < n; i++)
        candy[i] = 1;

    // Left to right: if rating increases, candy increases
    for (int i = 1; i < n; i++)
    {
        if (ratings[i] > ratings[i - 1])
        {
            candy[i] = candy[i - 1] + 1;
        }
    }

    // Right to left: ensure descending ratings satisfied
    for (int i = n - 2; i >= 0; i--)
    {
        if (ratings[i] > ratings[i + 1])
        {
            candy[i] = Math.Max(candy[i], candy[i + 1] + 1);
        }
    }

    // Sum up total candy
    int total = 0;
    foreach (int c in candy)
        total += c;

    return total;
}
```

```text
Example: ratings = [1,0,2]

Initial: candy = [1, 1, 1]

Left to Right Pass:
  i=1: ratings[1]=0 < ratings[0]=1 → candy[1] stays 1
  i=2: ratings[2]=2 > ratings[1]=0 → candy[2] = candy[1] + 1 = 2
  After: candy = [1, 1, 2]

Right to Left Pass:
  i=1: ratings[1]=0 < ratings[2]=2 → candy[1] stays 1
  i=0: ratings[0]=1 > ratings[1]=0 → candy[0] = MAX(1, 1+1) = 2
  After: candy = [2, 1, 2]

Total: 2 + 1 + 2 = 5 ✓
```

- **Time Complexity :** `O(n)` - two passes through array
- **Space Complexity :** `O(n)` - candy array of size n

---
