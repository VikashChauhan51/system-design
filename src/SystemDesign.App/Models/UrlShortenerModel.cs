using System.ComponentModel.DataAnnotations;

namespace SystemDesign.App.Models;


public class UrlShortenerModel
{
    [Required]
    [Url]
    [MaxLength(2000)]
    public string LongUrl { get; set; } = string.Empty;

    [MaxLength(8)]
    public string? Alias { get; set; }

    public string? ShortUrl { get; set; } 
}
