
namespace SystemDesign.Core.FileSystem;

public abstract class Entry
{
    public Directory Parent { get; private set; }
    public string Name { get; private set; }
    public DateTime Created { get; }
    public DateTime Updated { get; protected set; }
    public DateTime LastAccessed { get; private set; }


    protected Entry(string name, Directory parent)
    {
        Name = name;
        Created = DateTime.Now;
        Updated = DateTime.Now;
        LastAccessed = DateTime.Now;
        Parent = parent;
    }

    public bool Delete()
    {
        if (Parent is null) return false;
        return Parent.DeleteEntry(this);
    }

    public string GetFullPath()
    {
        if (Parent == null) return Name;
        return Path.Join(Parent.GetFullPath(), Name);
    }
    public void ChangeName(string name)
    {
        Name = name;
        Updated = DateTime.Now;
        ChangeLastAccessed();
    }

    public void ChangeLastAccessed()
    {
        LastAccessed = DateTime.Now;
    }

    public void ChangeParent(Directory parent)
    {
        Parent = parent;
        Updated = DateTime.Now;
        ChangeLastAccessed();
    }
    public abstract long Size();

}


