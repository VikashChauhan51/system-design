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
