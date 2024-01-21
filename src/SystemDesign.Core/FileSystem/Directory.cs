

namespace SystemDesign.Core.FileSystem;

public class Directory : Entry
{
    private readonly List<Entry> entries;

    public Directory(string name, Directory parent) : base(name, parent)
    {
        entries = new List<Entry>();
    }

    public override long Size()
    {
        long size = 0;
        foreach (var entry in entries)
        {
            size += entry.Size();
        }
        return size;
    }

    public int GetFilesCount()
    {
        int count = 0;
        foreach (var entry in entries)
        {
            if (entry is File)
            {
                count++;
            }
            else if (entry is Directory directory)
            {
                count++;
                count += directory.GetFilesCount();

            }
        }
        return count;
    }

    public bool DeleteEntry(Entry entry)
    {

        ChangeLastAccessed();
        return entries.Remove(entry);
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
        ChangeLastAccessed();
    }

    public IEnumerable<Entry> GetContents()
    {
        ChangeLastAccessed();
        return entries.ToList(); //Copy of orginal data

    }
}

