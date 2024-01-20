using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using System.Security.Cryptography;
using SystemDesign.App.Models;

namespace SystemDesign.App.Controllers;


public class UrlShortenerController : Controller
{
    private static readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();
    private static readonly ConcurrentDictionary<string, string> urlMap = new ConcurrentDictionary<string, string>();
    // A constant string of possible characters for the short url
    private const string UrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


    [HttpGet("{shortUrl}")]
    public IActionResult Index(string shortUrl)
    {
        var pair = urlMap.FirstOrDefault(p => p.Value == shortUrl);

        if (string.IsNullOrEmpty(pair.Key))
        {
            return View(new { url = shortUrl });
        }
        // 302 - Moved Temporarily
        return Redirect(pair.Key);

    }
    [HttpGet]
    public IActionResult ShortUrl()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ShortUrl(UrlShortenerModel request)
    {
        if (urlMap.TryGetValue(request.LongUrl, out var value))
        {
            request.ShortUrl = Url.Action(nameof(UrlShortenerController.Index), nameof(UrlShortenerController).Replace("Controller", ""), values: new { shortUrl = value }, protocol: Request.Scheme);   
            return View(request);
        }
        else
        {

            int maxTry = urlMap.Count;
            int counter = 0;

            // Generate a new short url
            string shortUrl = GenerateRandomString(7);

            // Check if the short url is already in the dictionary
            while (urlMap.FirstOrDefault(p => p.Value == shortUrl).Value == shortUrl && counter < maxTry)
            {
                Interlocked.Increment(ref counter);
                // Generate another short url
                shortUrl = GenerateRandomString(7);
            }

            // Add the mapping to the dictionary
            urlMap.TryAdd(request.LongUrl, shortUrl);

            // Return the new short url
            request.ShortUrl = Url.Action(nameof(UrlShortenerController.Index), nameof(UrlShortenerController).Replace("Controller", ""), new { shortUrl = shortUrl }, protocol: Request.Scheme);
            return View(request);

        }
    }

    private static string GenerateRandomString(int length)
    {
        // Create a byte array to store the random bytes
        byte[] bytes = new byte[length];

        rng.GetBytes(bytes);


        // Convert the byte array to a character array
        char[] chars = new char[length];
        for (int i = 0; i < length; i++)
        {
            // Use the byte value as an index to the UrlCharacters string
            chars[i] = UrlCharacters[bytes[i] % UrlCharacters.Length];
        }

        // Return the character array as a string
        return new string(chars);
    }
}
