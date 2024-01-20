using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using SystemDesign.App.Models;
using SystemDesign.Core;

namespace SystemDesign.App.Controllers;


public class UrlShortenerController : Controller
{
   

    /// <summary>
    ///  COllection to hold all unique urls.
    /// </summary>
    private static readonly ConcurrentDictionary<string, string> urlMap = new ConcurrentDictionary<string, string>();

    /// <summary>
    /// 62^8 = 218,340,105,584,896 
    /// Over 218 trillion possible unique 8-character strings.
    /// </summary>
    const int MAX_LENGTH = 8;


    [HttpGet("{key}")]
    public IActionResult Index(string key)
    {
        if (urlMap.TryGetValue(key, out var value))
        {
            // 302 - Moved Temporarily
            return Redirect(value);
        }

        return View(new { url = (string?)null });

    }


    [HttpGet]
    public IActionResult ShortUrl()
    {
        return View();
    }



    [HttpPost]
    public IActionResult ShortUrl(UrlShortenerModel request)
    {

        //check item already exists
        var urlItem = urlMap.FirstOrDefault(x => x.Value == request.LongUrl);
        if (urlItem.Value == request.LongUrl)
        {
            // return existing short url.
            request.ShortUrl = GenerateShortUrl(urlItem.Key);
            return View(request);
        }
        else
        {
            // check if alias already exist
            if (!string.IsNullOrEmpty(request.Alias))
            {
                if (urlMap.ContainsKey(request.Alias))
                {
                    return View(request);
                }
                // Add the mapping to the dictionary
                urlMap.TryAdd(request.Alias, request.LongUrl);

                // Return the new short url
                request.ShortUrl = GenerateShortUrl(request.Alias);
                return View(request);
            }
             
            
            int maxTry = urlMap.Count;
            int counter = 0;

            // Generate a new short url
            string shortUrl = RandomGenerator.GenerateRandomString(MAX_LENGTH);

            // Check if the short url is already in the dictionary
            while (urlMap.ContainsKey(shortUrl) && counter < maxTry)
            {
                Interlocked.Increment(ref counter);
                // Generate another short url
                shortUrl = RandomGenerator.GenerateRandomString(MAX_LENGTH);
            }

            // Add the mapping to the dictionary
            urlMap.TryAdd(shortUrl, request.LongUrl);

            // Return the new short url
            request.ShortUrl = GenerateShortUrl(shortUrl);
            return View(request);

        }
    }


    private string GenerateShortUrl(string key)
    {
        return Url.Action(nameof(UrlShortenerController.Index), nameof(UrlShortenerController).Replace("Controller", ""), new { key = key }, protocol: Request.Scheme);
    }
   
}
