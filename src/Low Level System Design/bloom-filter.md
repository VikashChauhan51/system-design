# BloomFilter

```C#

public class BloomFilter<T>
{
    private readonly BitArray bitArray;
    private readonly int size;
    private readonly int hashFunctionCount;

    public BloomFilter(int size, int hashFunctionCount)
    {
        this.size = size;
        this.hashFunctionCount = hashFunctionCount;
        bitArray = new BitArray(size);
    }

    public void Add(T item)
    {
        for (int i = 0; i < hashFunctionCount; i++)
        {
            int hash = GetHash(item, i);
            bitArray[hash % size] = true;
        }
    }

    public bool Contains(T item)
    {
        for (int i = 0; i < hashFunctionCount; i++)
        {
            int hash = GetHash(item, i);
            if (!bitArray[hash % size])
            {
                return false;
            }
        }
        return true;
    }

    private int GetHash(T item, int index)
    {
        return item is not null ? item.GetHashCode() * index : 0;
    }
}
```