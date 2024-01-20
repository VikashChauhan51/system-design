using System.ComponentModel.DataAnnotations;

namespace SystemDesign.App.Models;


public class UrlShortenerModel
{
    [Required]
    [Url]
    [MaxLength(2000)]
    public string? LongUrl { get; set; }

    public string? ShortUrl { get; set; } 
}
