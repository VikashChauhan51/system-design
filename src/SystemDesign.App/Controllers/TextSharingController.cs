using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using SystemDesign.App.Models;

namespace SystemDesign.App.Controllers;

/*
 
Cache: We can use both client side and service side cache. The server we can use Aside cache with LRU (Least Recent Used) policy with 1 day TTL (Time To Alive). Also invalidate cache (Write-Through) if user modified it.
Database: We can use Sql database to store snippet information.
Storage: Storage bucket is need to store the snippet file content.

 */

public class TextSharingController : Controller
{
    /// <summary>
    ///  Snippet file bucket collection.
    /// </summary>
    private static readonly ConcurrentDictionary<string, string> snippetBucketMap = new ConcurrentDictionary<string, string>();

    /// <summary>
    /// Snippets collection.
    /// </summary>
    private static readonly ConcurrentDictionary<string, TextSnippet> snippetMap = new ConcurrentDictionary<string, TextSnippet>();

    [HttpGet]
    [Route("TextSharing/Index")]
    public IActionResult Index()
    {
        List<TextSnippet> snippets = new List<TextSnippet>();
        foreach (var item in snippetMap)
        {
            item.Value.Id = item.Key;
            item.Value.Snippet = snippetBucketMap[item.Value.SnippetId];
            snippets.Add(item.Value);
        }
        return View(snippets);
    }


    [HttpGet]
    public IActionResult Details(string Id)
    {
        return View(GetSnippet(Id));
    }



    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(TextSnippet textSnippet)
    {
        var snippetId = Guid.NewGuid().ToString();
        var textId = Guid.NewGuid().ToString();
        if (snippetBucketMap.TryAdd(textId, textSnippet.Snippet))
        {
            textSnippet.SnippetId = textId;
            textSnippet.Snippet = string.Empty; //No need to save it into database. In real design please create seprate entity class.
            if (snippetMap.TryAdd(snippetId, textSnippet))
            {
                textSnippet.Id = snippetId;
            }
            return RedirectToAction("Index");
        }
        return View(textSnippet);
    }

    [HttpGet]
    public IActionResult Edit(string Id)
    {
        return View(GetSnippet(Id));
    }

    [HttpPost]
    public IActionResult Edit(TextSnippet textSnippet)
    {
        var oldSnippet = GetSnippet(textSnippet.Id);
        if (oldSnippet is not null)
        {
            snippetBucketMap.TryUpdate(textSnippet.SnippetId, textSnippet.Snippet, oldSnippet.Snippet);
            textSnippet.Snippet = string.Empty; //No need to save it into database. In real design please create seprate entity class.
            snippetMap.TryUpdate(textSnippet.Id, textSnippet, oldSnippet);
            return RedirectToAction("Index");
        }

        return View(textSnippet);
    }

    [HttpGet]
    public IActionResult Delete(string Id)
    {
        return View(GetSnippet(Id));
    }

    [HttpPost]
    public IActionResult Delete(TextSnippet textSnippet)
    {
        var oldSnippet = GetSnippet(textSnippet.Id);
        if (oldSnippet is not null)
        {
            snippetBucketMap.TryRemove(new KeyValuePair<string, string>(oldSnippet.SnippetId, oldSnippet.Snippet));
            snippetMap.TryRemove(new KeyValuePair<string, TextSnippet>(textSnippet.Id, oldSnippet));
            return RedirectToAction("Index");
        }

        return View(textSnippet);
    }

    private static TextSnippet GetSnippet(string Id)
    {
        TextSnippet result = new();
        if (snippetMap.TryGetValue(Id, out var value))
        {
            value.Id = Id;

            if (snippetBucketMap.TryGetValue(value.SnippetId, out var snippetText))
            {
                value.Snippet = snippetText;
            }
            result = value;
        }

        return result;
    }
}
