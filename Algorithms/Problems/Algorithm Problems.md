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
