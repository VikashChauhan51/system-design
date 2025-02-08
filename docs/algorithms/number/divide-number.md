---
outline: deep
---

# Divide Number

You are given an integer `n`. Your task is to create a function named `DivideNumber` that performs the following operations:

1. If the input number `n` is greater than or equal to 10, the function should recursively call itself with the integer division result of `n` by 10.
2. Once the recursive call returns, the function should output the integer division result of `n` by 10.

### Example

**Input:**
- `n = 274`

**Output:**
- `0`
- `2`
- `27`

## Solution

```C#
public class Solution
{
    public void DivideNumber(int n)
    {
        if (n >= 10)
        {
            DivideNumber(n / 10);
        }
        Console.WriteLine(n / 10);
    }
}
```

### Exmplanations

 Let's dry run the program with `274` as the input value, and trace the steps and values:

### Initial Call
1. **Input:** `n = 274`
2. **Condition:** `274 >= 10` (True)
3. **Recursive Call:** `DivideNumber(274 / 10)` → `DivideNumber(27)`

### First Recursive Call
4. **Input:** `n = 27`
5. **Condition:** `27 >= 10` (True)
6. **Recursive Call:** `DivideNumber(27 / 10)` → `DivideNumber(2)`

### Second Recursive Call
7. **Input:** `n = 2`
8. **Condition:** `2 >= 10` (False)
9. **Print Statement:** `Console.WriteLine(2 / 10)` → `Console.WriteLine(0)`
10. **Output:** `0`

### Returning to First Recursive Call
11. **Print Statement:** `Console.WriteLine(27 / 10)` → `Console.WriteLine(2)`
12. **Output:** `2`

### Returning to Initial Call
13. **Print Statement:** `Console.WriteLine(274 / 10)` → `Console.WriteLine(27)`
14. **Output:** `27`

### Final Output Sequence
- The sequence of printed values will be:
```
0
2
27
```
