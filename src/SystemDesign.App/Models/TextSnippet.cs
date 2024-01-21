using System.ComponentModel.DataAnnotations;

namespace SystemDesign.App.Models;

public class TextSnippet
{
    public string Id { get; set; } = string.Empty;

    [MaxLength(50)]
    public string? FileName { get; set; }
    public string? Description { get; set; }
    public string? Tags { get; set; }

    [Required]
    public string Snippet { get; set; } = string.Empty;

    public string SnippetId { get; set; } = string.Empty;
}
