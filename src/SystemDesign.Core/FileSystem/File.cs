using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDesign.Core.FileSystem;

public class File : Entry
{
    protected string Content;

    public File(string name, Directory parent, string content) : base(name, parent)
    {
        Content = content;
    }

    public void SetContent(string content)
    {
        Content = content;
        Updated = DateTime.Now;
        ChangeLastAccessed();
    }

    public string GetContent()
    {
        ChangeLastAccessed();
        return Content;
    }
    public override long Size() => Content?.Length ?? default;
}


