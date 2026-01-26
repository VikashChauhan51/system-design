# Algorithm Problems

```
Level 1: Number & Basic Operations (Foundation)
├── 1. Mod a number without `%` operator
├── 2. Divide numbers without `/` operator
├── 3. Square root of a number
└── 4. Sum of digits

Level 1: Recursion (Optimization Strategy)
├── 5. Factorial of a number
├── 6. Fibonacci Series
├── 7. Power of two numbers
├── 8. Count digits recursively
├── 9. Sum of digits recursively
├── 10. Count Zeroes Recursively
├── 11. Geometric Sum
└── 12. String to Integer

Level 1: Backtracking (Explore & Constraint Satisfaction)
├── 13. Print all subsequence
├── 14. Print All Permutation of String
├── 15. Staircase
├── 16. Tower of Hanoi
└── 17. Print Tower of Hanoi

Level 1: Bit Manipulation (Advanced Optimization)
├── 18. Count Number of 1 Bits
├── 19. Swap Two Numbers Without Temp
├── 20. Single Number (All appear twice except one)
├── 21. Find Missing Number in Array
├── 22. Add Two Numbers Without Arithmetic Operators
├── 23. Power (Optimized with Bitwise)
├── 24. Minimum Bit Flips to Convert Number
└── 25. Generate All Subsets

Level 1: String Manipulation (Pattern Matching & Transformation)
├── 26. Multiply two strings
├── 27. Reverse String
├── 28. Check for Anagrams
└── 29. Length of Last Word

Level 1: Array Operations (Collection Handling)
├── 30. Move Zeroes To End
├── 31. Duplicate Characters
├── 32. Contains Duplicate
├── 33. Valid Palindrome
├── 34. Fizz Buzz
└── 35. Longest Common Prefix
```

---

## Level 1: Number & Basic Operations (Foundation)

> `Brute force technique`

### 1. Mod a number without `%` operator

Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow.

```csharp
public static int Mod(int a, int b)
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

### 2. Divide numbers without `/` operator

Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow.

```csharp
public static int Divide(int a, int b)
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

### 3. Square root of a number

The number is a positive number and greater than zero.

```csharp
public static int Sqrt(int n)
{
    // The number is a positive number and greater than zero.
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

### 4. Sum of digits

The number is a positive number and greater than zero.

```csharp
public static int SumOfDigits(int num)
{
    // The number is a positive number and greater than zero.
    int sum = 0;
    while(num > 0)
    {
        int reminder = num % 10;
        sum += reminder;
        num = num / 10;
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

### 5. String to Integer

The input stringis not null or empty.
```csharp
public int StringToInt(string s)
{
    int result = 0;
    for (int i = 0; i < s.Length; i++)
    {
        result = result * 10 + (s[i] - '0');
    }
    return result;
}
```

```text
"d₀d₁d₂...dₙ₋₁" = (((...((d₀×10 + d₁)×10 + d₂)×10 + ...)×10 + dₙ₋₂)×10 + dₙ₋₁

input = "123"

0×10 + 1 = 1
1×10 + 2 = 12
12×10 + 3 = 123
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

### 6. Geometric Sum

```
The algorithm computes: ∑_{k=0}^{n} (1/2ᵏ) = 1 + 1/2 + 1/4 + 1/8 + ... + 1/2ⁿ
```

```csharp
public static double GeometricSum(int n)
{
    double sum = 1.0;  // 1/2⁰ = 1
    double term = 1.0;

    for (int i = 1; i <= n; i++)
    {
        term /= 2.0;  // Each term is half of previous
        sum += term;
    }
    return sum;
}
```

```text
Initial:
term = 1.0 = 1/2⁰
sum = 1.0 = 1/2⁰

i=1:
term = 1.0/2 = 0.5 = 1/2¹
sum = 1.0 + 0.5 = 1.5 = 1 + 1/2

i=2:
term = 0.5/2 = 0.25 = 1/2²
sum = 1.5 + 0.25 = 1.75 = 1 + 1/2 + 1/4

i=3:
term = 0.25/2 = 0.125 = 1/2³
sum = 1.75 + 0.125 = 1.875 = 1 + 1/2 + 1/4 + 1/8

i=4:
term = 0.125/2 = 0.0625 = 1/2⁴
sum = 1.875 + 0.0625 = 1.9375 = 1 + 1/2 + 1/4 + 1/8 + 1/16
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(1)`

### 7. Count Zeroes

```csharp
public static int CountZeroes(int n)
{
    if (n <= 0) return 0;
    int count = 0;
    while (n > 0)
    {
        if (n % 10 == 0) count++;
        n /= 10;
    }
    return count;
}
```

```text
n=101010, count=0
Process digits: 0,1,0,1,0,1
Zeros at positions: 1st, 3rd, 5th from right
Result: 3 ✓
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(1)`

## Level 1: Recursion (Optimization Strategy)
### 5. Factorial of a number

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

### 6. Fibonacci Series

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

### 7. Power of two numbers

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

### 8. Count digits recursively

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

### 9. Sum of digits recursively

```csharp
public static int SumOfDigits(int n)
{
    // Base cases
    if (n <= 0)
    {
        return 0;
    }

    // Inductive Hypothesis
    int smallResult = SumOfDigits(n / 10);

    // Inductive Step
    int lastDigit = n % 10;
    return smallResult + lastDigit;
}
```

```text
Call Stack (growing down):
SumOfDigits(1234) waiting, lastDigit=4
  SumOfDigits(123) waiting, lastDigit=3
    SumOfDigits(12) waiting, lastDigit=2
      SumOfDigits(1) waiting, lastDigit=1
        SumOfDigits(0) → returns 0
      returns 0 + 1 = 1
    returns 1 + 2 = 3
  returns 3 + 3 = 6
returns 6 + 4 = 10
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(log d)`

### 10. Count Zeroes Recursively

```csharp
public static int CountZeroes(int n)
{
    if (n <= 0)
    {
        return 0;
    }

    int smallResult = CountZeroes(n / 10);
    int lastDigit = n % 10;
    if (lastDigit == 0)
    {
        return smallResult + 1;
    }
    return smallResult;
}
```

```text
Call Stack (growing down):
CountZeroes(100304) waiting, lastDigit=4≠0
  CountZeroes(10030) waiting, lastDigit=0=0
    CountZeroes(1003) waiting, lastDigit=3≠0
      CountZeroes(100) waiting, lastDigit=0=0
        CountZeroes(10) waiting, lastDigit=0=0
          CountZeroes(1) waiting, lastDigit=1≠0
            CountZeroes(0) → returns 0
          returns 0
        returns 0 + 1 = 1
      returns 1 + 1 = 2
    returns 2
  returns 2 + 1 = 3
returns 3
```
- **Time Complexity :** `O(log n)`
- **Space Complexity :** `O(log d)`

### 11. Geometric Sum
Given an integer n, we need to find the geometric sum of the following series using recursion.

1 + 1/2 + 1/4 + 1/8 + ... + 1/(2n)

```csharp
public static double GeometricSum(int n)
{
    // Base case
    if (n == 0)
    {
        return 1;
    }

    // Inductive Hypothesis
    double smallResult = GeometricSum(n -1);

    //Inductive Step
    return smallResult + (1.0 / Math.Pow(2, n));
}
```

```text
Call Stack (growing down):
GeometricSum(3) waiting, will add 1/2³
  GeometricSum(2) waiting, will add 1/2²
    GeometricSum(1) waiting, will add 1/2¹
      GeometricSum(0) → returns 1.0
    returns 1.0 + 0.5 = 1.5
  returns 1.5 + 0.25 = 1.75
returns 1.75 + 0.125 = 1.875
```
- **Time Complexity :** `O(n)`
- **Space Complexity :** `O(d)`

### 12. String to Integer

```csharp
public int StringToInt(string s)
{
    // Base case
    if (s.Length == 0)
    {
        return 0;
    }

    // Inductive Hypothesis
    char lastChar = s[s.Length - 1];
    string restOfString = s.Substring(0, s.Length - 1);
    int smallResult = StringToInt(restOfString);

    // Inductive Step
    int lastDigit = lastChar - '0';
    return smallResult * 10 + lastDigit;
}

```
```text
Call Stack (growing down):
StringToInt("123") waiting, lastDigit=3
  StringToInt("12") waiting, lastDigit=2
    StringToInt("1") waiting, lastDigit=1
      StringToInt("") → returns 0
    returns 0*10 + 1 = 1
  returns 1*10 + 2 = 12
returns 12*10 + 3 = 123
```
- **Time Complexity :** `O(n²)`
    - Recursive calls: `n+1` calls for string of length `n`
    - Each call: `Substring(0, s.Length-1)` is `O(n)` operation
- **Space Complexity :** `O(d²)`
    - Call stack depth: `d` (when going down one branch)
    - String operations create new strings: `O(d²)` total space

## Level 1: Backtracking (Explore & Constraint Satisfaction)

### 13. Print all subsequence

```csharp
public void PrintAllSubsequence(string input, string output)
{
    // Base case
    if (input.Length == 0)
    {
        Console.WriteLine(output);
        return;
    }

    // Inductive Hypothesis
    char firstChar = input[0];
    string restOfString = input.Substring(1);
    // Inductive Step
    // Include the first character
    PrintAllSubsequence(restOfString, output + firstChar);
    // Exclude the first character
    PrintAllSubsequence(restOfString, output);
}
```

```text

                      Print("abc", "")
                           /        \
                          /          \
              Include 'a'            Exclude 'a'
            Print("bc", "a")        Print("bc", "")
                /    \                  /    \
               /      \                /      \
       Include 'b'  Exclude 'b'  Include 'b'  Exclude 'b'
   Print("c","ab") Print("c","a") Print("c","b") Print("c","")
        /    \         /    \         /    \         /    \
       /      \       /      \       /      \       /      \
   Inc 'c'  Exc 'c' Inc 'c' Exc 'c' Inc 'c' Exc 'c' Inc 'c' Exc 'c'
   "abc"    "ab"    "ac"    "a"     "bc"    "b"     "c"     ""

output:
"abc"
"ab"
"ac"
"a"
"bc"
"b"
"c"
""
```
- **Time Complexity :** `O(n × 2ⁿ)`
    - Total recursive calls: `2ⁿ⁺¹ - 1`
    - Each call: `O(n)` for Substring(1) operation
- **Space Complexity :** `O(d²)`
    - Call stack depth: `d` (when going down one branch)
    - String operations create new strings: `O(d²)` total space

### 14. Print All Permutation of String

Given a string s, the task is to return all permutations of a given string in lexicographically sorted order.
Note: A permutation is the rearrangement of all the elements of a string. Duplicate arrangement can exist.

```
Examples:
Input: s = "ABC"
Output: "ABC", "ACB", "BAC", "BCA", "CAB", "CBA"
Input: s = "XY"
Output: "XY", "YX"
Input: s = "AAA"
Output: "AAA", "AAA", "AAA", "AAA", "AAA", "AAA"
```
```csharp
public static void PrintAllPermutationOfString(char[] str, int index)
{
    // Base case
    if (index >= str.Length - 1 || str.Length == 0)
    {
        Console.WriteLine(new string(str));
        return;
    }

    // Inductive Hypothesis and Inductive Step
    for(int i = index; i < str.Length; i++)
    {
        // Swap the current index with the loop index
        char temp = str[index];
        str[index] = str[i];
        str[i] = temp;
        // Recurse for the next index
        PrintAllPermutationOfString(str, index + 1);
        // Backtrack: Swap back to the original configuration
        temp = str[index];
        str[index] = str[i];
        str[i] = temp;
    }
}

```
```text
Initial: ABC (index=0)
    │
    ├─ i=0: ABC → ABC (index=1)
    │        │
    │        ├─ i=1: ABC → ABC (index=2) → Print ABC
    │        │
    │        └─ i=2: ABC → ACB (index=2) → Print ACB
    │
    ├─ i=1: ABC → BAC (index=1)
    │        │
    │        ├─ i=1: BAC → BAC (index=2) → Print BAC
    │        │
    │        └─ i=2: BAC → BCA (index=2) → Print BCA
    │
    └─ i=2: ABC → CBA (index=1)
             │
             ├─ i=1: CBA → CBA (index=2) → Print CBA
             │
             └─ i=2: CBA → CAB (index=2) → Print CAB
```
- **Time Complexity :** `O(n × n!)`
    - Total permutations: `n!`
    - Each permutation: `O(n)` to print/construct string
    - Each permutation also requires `O(n)` swaps along the path
- **Space Complexity :** `O(n)`
    - Call stack depth: `n` (when going down one branch)
    - Character array: `O(n)` modified in-place

### 15. Staircase
There are n stairs, and a person standing at the bottom wants to climb stairs to reach the top. The person can climb either 1 stair or 2 stairs at a time, the task is to count the number of ways that a person can reach at the top.

```
Examples:
Input: n = 1
Output: 1
Explanation: There is only one way to climb 1 stair.
Input: n = 2
Output: 2
Explanation: There are two ways to reach 2th stair: {1, 1} and {2}.
Input: n = 4
Output: 5
Explanation: There are five ways to reach 4th stair: {1, 1, 1, 1}, {1, 1, 2}, {2, 1, 1}, {1, 2, 1} and {2, 2}.

```

```csharp

public int ClimbStairs(int n)
{
    // Base case
    if (n == 0 || n == 1)
    {
        return 1;
    }

    if (n == 2)
    {
        return 2;
    }

    //Inductive Hypothesis
    int waysFromNMinus1 = ClimbStairs(n - 1);
    int waysFromNMinus2 = ClimbStairs(n - 2);
    //Inductive Step
    return waysFromNMinus1 + waysFromNMinus2;
}

```

```text
ClimbStairs(6)
├─ ClimbStairs(5)  // Calculates ClimbStairs(4), ClimbStairs(3), etc.
│  ├─ ClimbStairs(4)  // Calculates ClimbStairs(3), ClimbStairs(2)
│  └─ ClimbStairs(3)  // Calculates ClimbStairs(2), ClimbStairs(1)
└─ ClimbStairs(4)  // **DUPLICATE!** Calculates same as above
   ├─ ClimbStairs(3)  // **DUPLICATE!**
   └─ ClimbStairs(2)  // **DUPLICATE!**
```
- **Time Complexity :** `O(2ⁿ)`
    - Each call makes 2 recursive calls (n-1 and n-2)
    - Forms a binary tree of depth ≈ n
    - Total nodes ≈ 2ⁿ (exponential growth)
- **Space Complexity :** `O(n)`
    - Call stack depth: `n` (when going down one branch)


### 16. Tower of Hanoi

Recursively calculates the minimum moves to solve Tower of Hanoi with n disks using the recurrence relation: `T(n) = 2×T(n-1) + 1`.

```csharp
public static int TowerOfHanoi(int n)
{
    // Base case
    if (n == 0)
    {
        return 0;
    }
    //Inductive Hypothesis
    int smallResult = TowerOfHanoi(n - 1);
    //Inductive Step
    return 2 * smallResult + 1;
}
```

```text
Call Stack (growing down):
TowerOfHanoi(3) waiting, will compute 2×?+1
  TowerOfHanoi(2) waiting, will compute 2×?+1
    TowerOfHanoi(1) waiting, will compute 2×?+1
      TowerOfHanoi(0) → returns 0
    returns 2×0+1 = 1
  returns 2×1+1 = 3
returns 2×3+1 = 7
```
- **Time Complexity :** `O(n)`
    - `n` recursive calls
- **Space Complexity :** `O(n)`
    - Call stack depth: `n` (when going down one branch)


### 17. Print  Tower of Hanoi

Tower of Hanoi is a mathematical puzzle where we have three rods (A, B, and C) and N disks. Initially, all the disks are stacked in decreasing value of diameter i.e., the smallest disk is placed on the top and they are on rod A. The objective of the puzzle is to move the entire stack to another rod (here considered C), obeying the following simple rules:
- Only one disk can be moved at a time.
- Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack i.e. a disk can only be moved if it is the uppermost disk on a stack.
- No disk may be placed on top of a smaller disk.

```
Examples:
Input: 2
Output: Disk 1 moved from A to B
Disk 2 moved from A to C
Disk 1 moved from B to C
Input: 3
Output: Disk 1 moved from A to C
Disk 2 moved from A to B
Disk 1 moved from C to B
Disk 3 moved from A to C
Disk 1 moved from B to A
Disk 2 moved from B to C
Disk 1 moved from A to C

```
```csharp
public void PrintTowerOfHanoiMoves(int n, char source, char destination, char auxiliary)
{
    // Base case
    if (n == 0)
    {
        return;
    }
    //Inductive Hypothesis and Inductive Step
    // Move n-1 disks from source to auxiliary
    PrintTowerOfHanoiMoves(n - 1, source, auxiliary, destination);
    // Move the nth disk from source to destination
    Console.WriteLine($"Move disk {n} from {source} to {destination}");
    // Move n-1 disks from auxiliary to destination
    PrintTowerOfHanoiMoves(n - 1, auxiliary, destination, source);
}
```

```text
PrintTowerOfHanoiMoves(3, A, C, B)
│
├─ PrintTowerOfHanoiMoves(2, A, B, C)
│  │
│  ├─ PrintTowerOfHanoiMoves(1, A, C, B)
│  │  └─ Print: "Move disk 1 from A to C" (1)
│  │
│  ├─ Print: "Move disk 2 from A to B" (2)
│  │
│  └─ PrintTowerOfHanoiMoves(1, C, B, A)
│     └─ Print: "Move disk 1 from C to B" (3)
│
├─ Print: "Move disk 3 from A to C" (4)
│
└─ PrintTowerOfHanoiMoves(2, B, C, A)
   │
   ├─ PrintTowerOfHanoiMoves(1, B, A, C)
   │  └─ Print: "Move disk 1 from B to A" (5)
   │
   ├─ Print: "Move disk 2 from B to C" (6)
   │
   └─ PrintTowerOfHanoiMoves(1, A, C, B)
      └─ Print: "Move disk 1 from A to C" (7)
```
- **Time Complexity :** `O(2ⁿ)`
    - Recurrence: `T(n) = 2×T(n-1) + 1`
- **Space Complexity :** `O(n)`
    - Call stack depth: `n` (when going down one branch)


### 36. Number to Text

```csharp
public class NumberToText
{
    private static string[] unitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    private static string[] tensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    public static string ConvertNumberToText(int number)
    {
        if (number == 0)
            return unitsMap[0];

        if (number < 20)
            return unitsMap[number];

        if (number < 100)
            return tensMap[number / 10] + ((number % 10 > 0) ? " " + ConvertNumberToText(number % 10) : "");

        if (number < 1000)
            return unitsMap[number / 100] + " Hundred" + ((number % 100 > 0) ? " " + ConvertNumberToText(number % 100) : "");

        if (number < 100000)
            return ConvertNumberToText(number / 1000) + " Thousand" + ((number % 1000 > 0) ? " " + ConvertNumberToText(number % 1000) : "");

        return ConvertNumberToText(number / 100000) + " Lac" + ((number % 100000 > 0) ? " " + ConvertNumberToText(number % 100000) : "");
    }
}
```

```text
ConvertNumberToText(123456)
│
├─ ConvertNumberToText(1) → "One"
│
└─ ConvertNumberToText(23456)
   │
   ├─ ConvertNumberToText(23)
   │  │
   │  ├─ tensMap[2] → "Twenty"
   │  │
   │  └─ ConvertNumberToText(3) → "Three"
   │     Result: "Twenty Three"
   │
   └─ ConvertNumberToText(456)
      │
      ├─ ConvertNumberToText(4) → "Four"
      │
      └─ ConvertNumberToText(56)
         │
         ├─ tensMap[5] → "Fifty"
         │
         └─ ConvertNumberToText(6) → "Six"
            Result: "Fifty Six"
         Result: "Four Hundred Fifty Six"
      Result: "Twenty Three Thousand Four Hundred Fifty Six"
   Result: "One Lac Twenty Three Thousand Four Hundred Fifty Six"
```
- **Time Complexity :** `O(log n)`
    - Each recursive call reduces the number by a factor (÷100000, ÷1000, ÷100, ÷10)
    - Number of digits = d = ⌊log₁₀(n)⌋ + 1
    - Maximum recursion depth ≈ number of digit groups = O(log n)
- **Space Complexity :** `O(log n)`
    - Call stack depth = O(log n) (number of digit groups)
    - String concatenation creates new strings, but total length = O(log n)
    - Arrays unitsMap and tensMap are constant size O(1)


### 37. Flatten

```csharp
public static List<object> FlattenList(IEnumerable<object> nestedList)
{
    List<object> result = new List<object>();

    foreach (var item in nestedList)
    {
        if (item is Array && !(item is string))
        {
            result.AddRange(FlattenList((IEnumerable<object>)item));
        }
        else
        {
            result.Add(item);
        }
    }

    return result;
}
```

```text
FlattenList([1, [2,3], [4,[5,6]], 7]) (Level 0)
│
├─ item=1 → Add 1 → result=[1]
│
├─ item=[2,3] (Array)
│  │
│  └─ FlattenList([2,3]) (Level 1)
│     │
│     ├─ item=2 → Add 2 → result=[2]
│     │
│     └─ item=3 → Add 3 → result=[2,3]
│        Return [2,3]
│  AddRange([2,3]) → result=[1,2,3]
│
├─ item=[4,[5,6]] (Array)
│  │
│  └─ FlattenList([4,[5,6]]) (Level 1)
│     │
│     ├─ item=4 → Add 4 → result=[4]
│     │
│     └─ item=[5,6] (Array)
│        │
│        └─ FlattenList([5,6]) (Level 2)
│           │
│           ├─ item=5 → Add 5 → result=[5]
│           │
│           └─ item=6 → Add 6 → result=[5,6]
│              Return [5,6]
│        AddRange([5,6]) → result=[4,5,6]
│     Return [4,5,6]
│  AddRange([4,5,6]) → result=[1,2,3,4,5,6]
│
└─ item=7 → Add 7 → result=[1,2,3,4,5,6,7]
   Return [1,2,3,4,5,6,7]
```
- **Time Complexity :** `O(n)`
    - `n` = total number of elements across all levels
- **Space Complexity :** `O(d)`
    - Call stack depth = O(d) (number of digit groups)
    - Additional `O(n)` space for result list

### 38. House Robber
You are a professional robber planning to rob houses along a street. Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, return the maximum amount of money you can rob tonight without alerting the police.

```
Example 1:
Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
Example 2:
Input: nums = [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
Total amount you can rob = 2 + 9 + 1 = 12.

```

```csharp
public static int Rob(int[] nums, int n)
{
    if (n < 0)
    {
        return 0;
    }
    int includeCurrent = nums[n] + Rob(nums, n - 2);
    int excludeCurrent = Rob(nums, n - 1);
    return Math.Max(includeCurrent, excludeCurrent);
}

```
- **Time Complexity :** `O(2ⁿ)`
    - Each call makes 2 recursive calls (n-1 and n-2)
    - Forms binary tree with ≈ 2ⁿ nodes
- **Space Complexity :** `O(d)`
    - Call stack depth = O(d) (number of digit groups)


## Level 1: Bit Manipulation (Advanced Optimization)
### 18. Count Number of 1 Bits

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

### 19. Swap Two Numbers Without Temp

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

### 20. Single Number (All appear twice except one)

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

### 21. Find Missing Number in Array

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

### 22. Add Two Numbers Without Arithmetic Operators

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

### 23. Power (Optimized with Bitwise)

Both numbers are positive number and greater than zero.

```csharp
public static int PowerOptimized(int x, int n)
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

### 24. Minimum Bit Flips to Convert Number

The number is a positive number and greater than zero.

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

### 25. Generate All Subsets

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

## Level 1: String Manipulation (Pattern Matching & Transformation)
### 26. Multiply two strings

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

### 27. Reverse String

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

### 28. Check for Anagrams

An anagram of a string is another string that contains the same characters, only the order of characters can be different.

#### Constraints

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

### 29. Length of Last Word

The string is not null.

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

## Level 1: Array Operations (Collection Handling)
### 30. Move Zeroes To End

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

### 31. Duplicate Characters

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

### 32. Contains Duplicate

The array is not null. Please complete with `O(1)` space complexity.

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

### 33. Valid Palindrome

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

### 34. Fizz Buzz

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

### 35. Longest Common Prefix

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
