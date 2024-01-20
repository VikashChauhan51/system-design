using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace SystemDesign.Controllers;


[ApiController]
[Route("[controller]")]
[EnableCors("AllowAllOrigins")]
public class UrlShortenerController : ControllerBase
{
    private static readonly RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
    private static readonly ConcurrentDictionary<string, string> urlMap = new ConcurrentDictionary<string, string>();
    // A constant string of possible characters for the short url
    private const string UrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
    private readonly ILogger<UrlShortenerController> _logger;

    public UrlShortenerController(ILogger<UrlShortenerController> logger)
    {
        _logger = logger;
    }


    [HttpOptions]
    public IActionResult PreflightRoute()
    {
        Response.Headers.Add("Access-Control-Allow-Origin", "*");
        Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE");
        Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
        return Ok();
    }


    [HttpGet]
    public IActionResult Get(string shortUrl)
    {
        var pair = urlMap.FirstOrDefault(p => p.Value == shortUrl);

        if (string.IsNullOrEmpty(pair.Key))
        {
            return NotFound();
        }

        return Ok(new { url = pair.Key });
    }

    [HttpPost]
    public IActionResult ShortUrl(string longUrl)
    {
        if (urlMap.TryGetValue(longUrl, out var value))
        {
            return Ok(new { url = value });
        }
        else
        {
            // Generate a new short url
            string shortUrl = GenerateRandomString(7);

            // Check if the short url is already in the dictionary
            while (urlMap.FirstOrDefault(p => p.Value == shortUrl).Value == shortUrl)
            {
                // Generate another short url
                shortUrl = GenerateRandomString(7);
            }

            // Add the mapping to the dictionary
            urlMap.TryAdd(longUrl, shortUrl);

            // Return the new short url
            return Ok(new { url = shortUrl });
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
