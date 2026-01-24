# Algorithm Problems

> `Brute force technique`
## 1. Mod a number without `%` operator

Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow.

```csharp

public static int Mod( int a, int b)
{
    // Both numbers are positive number and greater than zero.
    // Example: a = 5, b = 3
    // 5 / 3 = 1 (integer division)
    int quotient = a / b;
    // Calculate remainder: 5 - (1 * 3) = 2
    int remainder = a - quotient * b;
    // Return remainder: 2
    return remainder;
}
```
```text
┌─────────────────────────────────────────────────────┐
│                   Mod(5, 3)                         │
└─────────────────────────────────────────────────────┘

        Step 1: Integer Division
        ┌─────────────────────────────┐
        │ quotient = a / b            │
        │ quotient = 5 / 3            │
        │ quotient = 1                │
        └─────────────────────────────┘
               │
               │ (Integer division truncates)
               ▼

        Step 2: Calculate Remainder
        ┌─────────────────────────────┐
        │ remainder = a - quotient * b│
        │ remainder = 5 - (1 * 3)     │
        │ remainder = 5 - 3           │
        │ remainder = 2               │
        └─────────────────────────────┘
               │
               ▼

        Step 3: Return Result
        Returns: 2 ✅
```
- **Time Complexity :** `O(1)`
- **Space Complexity :** `O(1)`

## 2. Divide numbers without `/` operator
Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow.

```csharp
public static int Divide( int a, int b)
{
    // Both numbers are positive number and greater than zero.
    // Example: a = 5, b = 3

    int count = 0;
    int sum = b;
    while(sum <= a)
    {
        count++;
        sum += b;
    }

    return count;
}
```
```text
Divide(10, 3)
      │
      ├── Initialize: count=0, sum=3
      │
      ├── Loop: sum <= 10?
      │   ├── sum=3 ≤10 ✓ → count=1, sum=6
      │   ├── sum=6 ≤10 ✓ → count=2, sum=9
      │   ├── sum=9 ≤10 ✓ → count=3, sum=12
      │   └── sum=12 ≤10 ✗ → STOP
      │
      └── Return: count=3
```
- **Time Complexity :** `O(a/b)`
- **Space Complexity :** `O(1)`

## 3. Power of two numbers
Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow/ stack overflow.

```csharp

public static int Power(int a, int n)
{
    // Both numbers are positive number and greater than zero.
    // Handle edge cases
    if (n < 0)
    {
        // Exponent must be non-negative
        return -1;
    }

    // Base case
    if (n == 0)
    {
        return 1;
    }

    // Recursive case
    int remainingProblem = Power(a, n - 1);

    // Combine solutions
    return a * remainingProblem;
}
```
```text
Power(3, 4)
  → Power(3, 3)
    → Power(3, 2)
      → Power(3, 1)
        → Power(3, 0)  // Base case
        ← returns 1
      ← returns 3 * 1 = 3
    ← returns 3 * 3 = 9
  ← returns 3 * 9 = 27
← returns 3 * 27 = 81
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

## 4. Square root of a number

The number is a  positive number and greater than zero.

```csharp
public static int Sqrt( int n)
{
    // The number is a  positive number and greater than zero.
    if (n == 0)
    {
        return 0;
    }

    int i = 1;
    while (i * i <= n)
    {
        i++;
    }

    return i - 1;  // Floor sqrt

}
```

```text
n = 25
i = 1

Loop iterations:
┌───────────────────────────────────────┐
│ Iteration 1: i=1, 1*1=1 <=25 ✓ → i=2  │
│ Iteration 2: i=2, 4 <=25 ✓ → i=3      │
│ Iteration 3: i=3, 9 <=25 ✓ → i=4      │
│ Iteration 4: i=4, 16 <=25 ✓ → i=5     │
│ Iteration 5: i=5, 25 <=25 ✓ → i=6     │
│ Iteration 6: i=6, 36 <=25 ✗ → STOP    │
└───────────────────────────────────────┘

return i-1 = 6-1 = 5 ✅
```
- **Time Complexity :** `O(√n)`
- **Space Complexity :** `O(1)`

## 5. Sum of digits
The number is a positive number and greater than zero.

```csharp
public static int SumOfDigits(int num)
{
    // The number is a positive number and greater than zero.
    int sum = 0;
    while( num > 0)
    {
        int reminder = num %10;
        sum += reminder;
        num = num/10;
    }

    return sum;
}
```
```text
SumOfDigits(9876)
─────────────────
Iteration 1: num=9876 → remainder=6, sum=6, num=987
Iteration 2: num=987 → remainder=7, sum=13, num=98
Iteration 3: num=98 → remainder=8, sum=21, num=9
Iteration 4: num=9 → remainder=9, sum=30, num=0
Return: 30 ✓ (9+8+7+6=30)
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

## 6. Factorial of a number
The number is a positive number and greater than zero.

```csharp
public static int FactorialRecursive(int n)
{
    // Base case: 0! = 1
    if (n == 0) return 1;

    // Recursive case: n! = n × (n-1)!
    return n * FactorialRecursive(n - 1);
}
```

```text
FactorialRecursive(5)
  → 5 * FactorialRecursive(4)
    → 4 * FactorialRecursive(3)
      → 3 * FactorialRecursive(2)
        → 2 * FactorialRecursive(1)
          → 1 * FactorialRecursive(0)
            → Base case: return 1
          ← returns 1 * 1 = 1
        ← returns 2 * 1 = 2
      ← returns 3 * 2 = 6
    ← returns 4 * 6 = 24
  ← returns 5 * 24 = 120
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

## 7. Fibonacci Series
The number is a positive number and greater than zero.

```csharp
public static int FibonacciRecursive(int n)
{
    // Base cases
    if (n <= 0) return 0;
    if (n == 1) return 1;

    // Recursive case: F(n) = F(n-1) + F(n-2)
    return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
}
```
```text
F(0) = 0
F(1) = 1
F(2) = F(1) + F(0) = 1 + 0 = 1
F(3) = F(2) + F(1) = 1 + 1 = 2
F(4) = F(3) + F(2) = 2 + 1 = 3
F(5) = F(4) + F(3) = 3 + 2 = 5
```

```text
               Fibonacci(5)
               /          \
      Fibonacci(4)      Fibonacci(3)
       /       \          /       \
  Fib(3)     Fib(2)    Fib(2)   Fib(1)
   /   \      /   \     /   \      1
Fib(2) Fib(1) Fib(1) Fib(0) Fib(1) Fib(0)
 /   \    1     1      0      1      0
Fib(1) Fib(0)
   1      0

Calculation:
Fib(2) = Fib(1) + Fib(0) = 1 + 0 = 1
Fib(3) = Fib(2) + Fib(1) = 1 + 1 = 2
Fib(4) = Fib(3) + Fib(2) = 2 + 1 = 3
Fib(5) = Fib(4) + Fib(3) = 3 + 2 = 5
```
- **Time Complexity :** `O(2ⁿ)`
- **Space Complexity :** `O(n)`


## 8. Multiply two strings
Both strings are not null and contains only positive numbers.

```csharp

public static string Multiply(string num1, string num2)
{
    // Both strings are not null and contains only positive numbers.
    if(num1 == "0" || num2 == "0")
    {
        return "0";
    }

    int m = num1.Length;
    int n = num2.Length;
    // (m + n)
    int[] result = new int [m + n];

    // right to left
    for(int i = m - 1; i >= 0; i--)
    {
        for(int j = n - 1; j >= 0; j--)
        {
            // convert to integer
            int digit1 = num1[i] - '0';
            int digit2 = num2[j] - '0';

            int mul = digit1* digit2;

            int carryIndex = i + j;
            int valueIndex =  i + j + 1;
            int sum = mul + result[valueIndex];  // This adds to existing
            // (15/10 = 1)
            int carry = sum / 10;
            // (15%10 = 5)
            int digit = sum % 10;

            result[valueIndex] = digit; // Set to digit
            result[carryIndex] += carry; // Add carry (accumulate)

        }
    }

    var output = new StringBuilder();
     for(int a = 0; a < result.Length; a++)
     {
        if(output.Length == 0 && result[a] == 0)
        {
            // remove leading zeros
            continue;
        }
        output.Append(result[a]);
     }

     return output.Length > 0 ? output.ToString() : "0";
}
```

```text
num1: "12" i=0;
num2: "13" j=0;

ITERATION MAP:
──────────────┬──────────────────────┬────────────────────────────
 Iteration    │  Positions Used      │  Result Array Evolution
──────────────┼──────────────────────┼────────────────────────────
 Initial      │                      │  [0, 0, 0, 0]
──────────────┼──────────────────────┼────────────────────────────
 i=1, j=1     │  carry[2], value[3]  │  [0, 0, 0, 6]  (2×3=6)
              │       ┌─────┐        │         ↑
              │       │     │        │
──────────────┼───────┼─────┼────────┼────────────────────────────
 i=1, j=0     │  carry[1], value[2]  │  [0, 0, 2, 6]  (2×1=2)
              │    ┌──┘     │        │      ↑
              │    │        │        │
──────────────┼────┼────────┼────────┼────────────────────────────
 i=0, j=1     │  carry[1], value[2]  │  [0, 0, 5, 6]  (1×3=3+2=5)
              │    ↑  ┌─────┘        │      ↑ (overwrites)
              │    │  │              │
──────────────┼────┼──┼──────────────┼────────────────────────────
 i=0, j=0     │  carry[0], value[1]  │  [0, 1, 5, 6]  (1×1=1)
              │  ┌─┘  ↑              │    ↑
              │  │    │              │
──────────────┴──┴────┴──────────────┴────────────────────────────
```
- **Time Complexity :** `O(m*n)`
- **Space Complexity :** `O(m+n)`


## 9. Count Number of 1 Bits
The number is a positive number and greater than zero.

```csharp
public static int CountBits(int n)
{
    int count = 0;
    while(n > 0)
    {
        count += n & 1;
        n = n >> 1;
    }
    return count;
}
```
```text
n = 13 (1101)
     ↓
Iteration 1: Check 1✓ → count=1, n=6(110)
Iteration 2: Check 0✗ → count=1, n=3(11)
Iteration 3: Check 1✓ → count=2, n=1(1)
Iteration 4: Check 1✓ → count=3, n=0

Return: 3
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

## 10. Swap Two Numbers Without Temp
Both numbers are positive number and greater than zero.

```csharp
public static void Swap(ref int a, ref int b)
{
    a = a ^ b;  // a now holds a XOR b
    b = a ^ b;  // b becomes original a
    a = a ^ b;  // a becomes original b
}
```
```text
Initial:   a = 5, b = 3
        ↓
Step 1: a = 5⊕3 = 6, b = 3
        ↓
Step 2: a = 6, b = 6⊕3 = 5
        ↓
Step 3: a = 6⊕5 = 3, b = 5
        ↓
Final:   a = 3, b = 5  ✓ Swapped!
```
- **Time Complexity :** `O(1)`
- **Space Complexity :** `O(1)`

## 11. Single Number (All appear twice except one)
The numbers are positive numbers.

```csharp
public static int SingleNumber(int[] nums)
{
    int result = 0;
    for (int num : nums)
    {
        result ^= num;
    }
    return result;
}
```
```text
[4, 1, 2, 1, 2]
 │  │  │  │  │
 ├──┼──┼──┼──┘
 │  │  │  └── Pair cancels (1⊕1=0)
 │  │  └───── Pair cancels (2⊕2=0)
 │  └──────── Single remains: 4
 └───────────
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 12. Find Missing Number in Array
Array of size `n` containing numbers from `0` to `n`, one missing.

```csharp
public static int MissingNumber(int[] nums)
{
    int n = nums.Length;
    int xor = 0;
     // XOR all array elements
    for (int i = 0; i < nums.Length; i++)
    {
        xor ^= nums[i];
    }

    // XOR all numbers from 0 to n
    for (int i = 0; i <= nums.Length; i++)
    {
        xor ^= i;
    }

    return xor;  // Missing number
}
```
```text
input: [3, 0, 1]
Array XOR:   3 ⊕ 0 ⊕ 1 = ?
Range XOR:   0 ⊕ 1 ⊕ 2 ⊕ 3 = ?

Combine: (3 ⊕ 0 ⊕ 1) ⊕ (0 ⊕ 1 ⊕ 2 ⊕ 3)

Cancel pairs:
   3's cancel: (3 from array) ⊕ (3 from range) = 0
   0's cancel: (0 from array) ⊕ (0 from range) = 0
   1's cancel: (1 from array) ⊕ (1 from range) = 0

What remains? 2 (only in range, not in array)
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 13. Add Two Numbers Without Arithmetic Operators
Both numbers are positive number and greater than zero.

```csharp
public static int Add(int a, int b)
{
    while (b != 0)
    {
        int carry = a & b;
        a = a ^ b;
        b = carry << 1;
    }
    return a;
}
```

```text
  0101 (5)
+ 0011 (3)
  ----
  1000 (8)

Iteration | a (binary) | b (binary) | carry | a ^ b | carry << 1
----------|------------|------------|-------|-------|-----------
Initial  | 0101 (5)   | 0011 (3)   |       |       |
1        | 0101 (5)   | 0011 (3)   | 0001  | 0110  | 0010
After 1  | 0110 (6)   | 0010 (2)   |       |       |
2        | 0110 (6)   | 0010 (2)   | 0010  | 0100  | 0100
After 2  | 0100 (4)   | 0100 (4)   |       |       |
3        | 0100 (4)   | 0100 (4)   | 0100  | 0000  | 1000
After 3  | 0000 (0)   | 1000 (8)   |       |       |
4        | 0000 (0)   | 1000 (8)   | 0000  | 1000  | 0000
Final    | 1000 (8)   | 0000 (0)   |       |       |
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

## 14. Power (Optimized with Bitwise)
Both numbers are positive number and greater than zero.

```csharp
public static int Power(int x, int n)
{
    if (n < 0) return 0;  // Handle negative
    if (n == 0) return 1;

    int result = 1;

    while (n > 0)
    {
        // If n is odd, multiply result by x
        if ((n & 1) == 1)
        {
            result *= x;
        }

        // Square x and halve n
        x *= x;
        n >>= 1;  // n = n / 2
    }

    return result;
}
```

```text
// 3^5 = 3^(101)₂
// 5=101, result=1
// n=101(odd) → result=3, x=9, n=10
// n=10(even)→ result=3, x=81, n=1
// n=1(odd) → result=243, x=6561, n=0
// Result=243 ✓
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

## 15. Minimum Bit Flips to Convert Number
The number is a  positive number and greater than zero.

```csharp
public static int MinBitFlips(int start, int goal)
{
    // Count differing bits
    int xor = start ^ goal;

   int count = 0;
    while (xor > 0)
    {
        count += xor & 1;
        xor >>= 1;
    }

    return count;
}
```
```text
start: 3 = 0011
goal:  4 = 0100
xor:   3 ^ 4 = 0011 ^ 0100 = 0111 (7)

Count 1s in 0111:
  0 1 1 1
  │ │ │ │
  │ │ │ └─ 1 (count=1)
  │ │ └─── 1 (count=2)
  │ └───── 1 (count=3)
  └─────── 0 (done)

Result: 3 bit flips needed
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

## 16. Generate All Subsets

```csharp
public static List<List<int>> GenerateSubsets(int[] nums)
{
    List<List<int>> subsets = new List<List<int>>();
    int n = nums.Length;

    // 2^n possible subsets
    for (int mask = 0; mask < (1 << n); mask++)
    {
        List<int> subset = new List<int>();

        for (int i = 0; i < n; i++)
        {
            // Check if i-th bit is set in mask
            if ((mask & (1 << i)) != 0)
            {
                subset.Add(nums[i]);
            }
        }

        subsets.Add(subset);
    }

    return subsets;
}
```
```text
// Example: nums=[1,2,3]
// mask=0(000): []
// mask=1(001): [1]
// mask=2(010): [2]
// mask=3(011): [1,2]
// mask=4(100): [3]
// mask=5(101): [1,3]
// mask=6(110): [2,3]
// mask=7(111): [1,2,3]
```

- **Time Complexity :** `O(n × 2ⁿ)`
- **Space Complexity :** `O(n × 2ⁿ)`

## 17. Move Zeroes To End
The numbers are positive numbers.

```csharp
public static void MoveZeroes(int[] nums)
{
    int lastNonZeroIndex = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != 0)
        {
            nums[lastNonZeroIndex++] = nums[i];

        }
    }

    for (int i = lastNonZeroIndex; i < nums.Length; i++)
    {
        nums[i] = 0;

    }
}
```

```text
Initial: [4, 2, 0, 1, 0, 3, 0]

Pass 1:
  i=0: 4 → pos 0, L=1: [4, 2, 0, 1, 0, 3, 0]
  i=1: 2 → pos 1, L=2: [4, 2, 0, 1, 0, 3, 0]
  i=2: 0 → skip
  i=3: 1 → pos 2, L=3: [4, 2, 1, 1, 0, 3, 0]
  i=4: 0 → skip
  i=5: 3 → pos 3, L=4: [4, 2, 1, 3, 0, 3, 0]
  i=6: 0 → skip

After pass 1: [4, 2, 1, 3, 0, 3, 0], L=4

Pass 2 (fill zeros from index 4):
  [4, 2, 1, 3, 0, 3, 0] → [4, 2, 1, 3, 0, 0, 0]

Final: [4, 2, 1, 3, 0, 0, 0]
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 18. Reverse String
The string is not null.

```csharp
public static string ReverseString(string s)
{
    char[] chars = s.ToCharArray();
    int left = 0;
    int right = chars.Length - 1;
    while (left < right)
    {
        char temp = chars[left];
        chars[left] = chars[right];
        chars[right] = temp;
        left++;
        right--;
    }
    return new string(chars);
}
```

```text
Initial:  h  e  l  l  o
          ↑           ↑
         left       right

Swap 1:  o  e  l  l  h
             ↑     ↑
            left  right

Swap 2:  o  l  l  e  h
                ↑
              left/right

Final:   o  l  l  e  h
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

## 19. Check for Anagrams

An anagram of a string is another string that contains the same characters, only the order of characters can be different.

### Constrants

Both strings are not null.


```csharp
public static bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    int[] charCount = new int[256];
    foreach (char c in s)
    {
        charCount[c]++;
    }

    foreach (char c in t)
    {
        if(charCount[c] == 0)
        {
            return false;
        }

        charCount[c]--;
    }

    return true;
}
```

```text
String s: a n a g r a m
Count:    a:3, n:1, g:1, r:1, m:1

String t: n a g a r a m
Check:    n✓ a✓ g✓ a✓ r✓ a✓ m✓ → All good!
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 20. Length of Last Word
The string is not null

```csharp
public static int LengthOfLastWord(string s)
{
    int length = 0;
    int i = s.Length - 1;

    // Skip trailing spaces
    while (i >= 0 && s[i] == ' ') i--;

    // Count last word from end
    while (i >= 0 && s[i] != ' ')
    {
        length++;
        i--;
    }

    return length;
}
```

```text
String: "  H e l l o   W o r l d  "
Index:   0 1 2 3 4 5 6 7 8 9 10 11 12 13 14
          ↑ ← ← ← ← ← ← ← ← ← ← ← ← ← ← ← ← Start from end

Step 1: Skip trailing spaces (← moves left)
        14: ' ' ← skip
        13: ' ' ← skip
        12: 'd' ✓ stop skipping

Step 2: Count characters until space (← moves left, ✓ counts)
        12: 'd' ✓ count=1
        11: 'l' ✓ count=2
        10: 'r' ✓ count=3
        9:  'o' ✓ count=4
        8:  'W' ✓ count=5
        7:  ' ' ✗ stop counting

Result: 5 characters in last word
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 21. Duplicate Characters
The string is not null.

```csharp
public static string DuplicateCharacters(string s)
{
    char[] charCount = new char[256];
    foreach (char c in s)
    {
        charCount[c]++;
    }

    StringBuilder result = new StringBuilder();
    foreach (char c in s)
    {
        if (charCount[c] > 1)
        {
            result.Append(c);
        }
    }

    return result.ToString();

}
```
```text
String: p r o g r a m m i n g
Index:  1 2 3 4 5 6 7 8 9 10 11

Step 1: Count occurrences
  p:1, r:2, o:1, g:2, a:1, m:2, i:1, n:1

Step 2: Mark duplicates
  Duplicates: r(✓), g(✓), m(✓)

Step 3: Collect in original order
  p(✗) r(✓) o(✗) g(✓) r(✓) a(✗) m(✓) m(✓) i(✗) n(✗) g(✓)
  Result: r g r m m g
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 22. Contains Duplicate
The array is not null. Please complete with `o(1)` space complexity.


```csharp
public static bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[i] == nums[j])
            {
                return true;
            }

        }
    }
    return false;
}
```
```text
nums = [1, 2, 3, 1]
Compare each pair (i, j) where j > i:

    j=0 j=1 j=2 j=3
i=0  -   1=2 1=3 1=1 ✓
i=1       -   2=3 2=1
i=2            -   3=1
i=3                -

Comparisons made:
(0,1): 1 vs 2 ✗
(0,2): 1 vs 3 ✗
(0,3): 1 vs 1 ✓ → Found duplicate!
```
- **Time Complexity :** `O(n²)`
- **Space Complexity :** `O(1)`

## 23. Valid Palindrome
The string is not null.

```csharp
public static bool IsPalindrome(string s)
{
    int left = 0;
    int right = s.Length - 1;

    while (left < right)
    {
        if(s[left] != s[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}
```
```text
String:  r a c e c a r
         ↑           ↑
        left       right  (Compare: r==r ✓)

         r a c e c a r
           ↑       ↑
          left   right   (Compare: a==a ✓)

         r a c e c a r
             ↑   ↑
            left right  (Compare: c==c ✓)

         r a c e c a r
               ↑
            left/right  (Done!)
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

## 24. Fizz Buzz
Given an integer `n`, return a string array answer (1-indexed) where:
- answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
- answer[i] == "Fizz" if i is divisible by 3.
- answer[i] == "Buzz" if i is divisible by 5.
- answer[i] == i (as a string) if none of the above conditions are true.

```csharp
public static IList<string> FizzBuzz(int n)
{
    var result = new List<string>();

    for (int i = 1; i <= n; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            result.Add("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            result.Add("Fizz");
        }
        else if (i % 5 == 0)
        {
            result.Add("Buzz");
        }
        else
        {
            result.Add(i.ToString());
        }
    }
    return result;
}

```
```text
n = 15

["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"]
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(n)`

## 25. Longest Common Prefix
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

## 26. Count digits recursively

```csharp
public static int CountDigits(int n)
{
    if (n <= 0)
    {
        return 0;
    }

    return 1 + CountDigits(n / 10);
}

```

```text
Call Stack (growing down):
CountDigits(1234)      → waiting for result
  CountDigits(123)     → waiting for result
    CountDigits(12)    → waiting for result
      CountDigits(1)   → waiting for result
        CountDigits(0) → returns 0
      returns 1 + 0 = 1
    returns 1 + 1 = 2
  returns 1 + 2 = 3
returns 1 + 3 = 4

CountDigits(1234) = 1 + CountDigits(123)
                  = 1 + (1 + CountDigits(12))
                  = 1 + (1 + (1 + CountDigits(1)))
                  = 1 + (1 + (1 + (1 + CountDigits(0))))
                  = 1 + (1 + (1 + (1 + 0)))
                  = 1 + (1 + (1 + 1))
                  = 1 + (1 + 2)
                  = 1 + 3
                  = 4
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(log n)`
