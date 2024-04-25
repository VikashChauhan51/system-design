# Heap Sort

```C#
public class HeapSort
{
    //Time complexity:It takes O(logn) for heapify and O(n) for constructing a heap. Hence, the overall time complexity of heap sort using min heap or max heap is O(n log n)
    //Space complexity: O(n) for call stack
    //Auxiliary Space complexity: O(1)  for swap two items

    public void Accending(int[] nums)
    {
        int N = nums.Length;
        for (int i = N / 2 - 1; i >= 0; i--)
        {
            MaxHeap(nums, N, i);
        }

        for (int j = N - 1; j >= 0; j--)
        {
            int temp = nums[0];
            nums[0] = nums[j];
            nums[j] = temp;
            MaxHeap(nums, j, 0);
        }
    }
    public void Decreasing(int[] nums)
    {
        int N = nums.Length;
        for (int i = N / 2 - 1; i >= 0; i--)
        {
            MinHeap(nums, N, i);
        }

        for (int j = N - 1; j >= 0; j--)
        {
            int temp = nums[0];
            nums[0] = nums[j];
            nums[j] = temp;
            MinHeap(nums, j, 0);
        }
    }

    private void MaxHeap(int[] nums, int N, int index)
    {
        int largest = index;
        int left = 2 * index + 1;
        int right = 2 * index + 2;

        if (left < N && nums[left] > nums[largest])
        {
            largest = left;
        }
        if (right < N && nums[right] > nums[largest])
        {
            largest = right;
        }

        if (largest != index)
        {
            int temp = nums[index];
            nums[index] = nums[largest];
            nums[largest] = temp;

            MaxHeap(nums, N, largest);
        }
    }

    private void MinHeap(int[] nums, int N, int index)
    {
        int smallest = index;
        int left = 2 * index + 1;
        int right = 2 * index + 2;

        if (left < N && nums[left] < nums[smallest])
        {
            smallest = left;
        }
        if (right < N && nums[right] < nums[smallest])
        {
            smallest = right;
        }

        if (smallest != index)
        {
            int temp = nums[index];
            nums[index] = nums[smallest];
            nums[smallest] = temp;

            MinHeap(nums, N, smallest);
        }
    }
}
```