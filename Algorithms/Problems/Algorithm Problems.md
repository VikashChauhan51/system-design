# Algorithm Problems

> `Brute force technique`
## Mod a number without `%` operator

Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow.

```C#

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

## Divide numbers without `/` operator
Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow.

```C#
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

## Power of two numbers
Both numbers are positive number and greater than zero.
Also number within the integer range so there is no overflow/ stack overflow.

```C#

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

## Square root of a number

The number is a  positive number and greater than zero.

```C#
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

## Sum of digits
The number is a positive number and greater than zero.

```C#
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

## Multiply two strings
Both strings are not null and contains only positive numbers.

```C#

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
