using System.ComponentModel.DataAnnotations;

namespace TeamDirectoryApi.Models;

public class StudyTool
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string ToolName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Category { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Platform { get; set; } = string.Empty;

    public bool IsFree { get; set; }

    [MaxLength(150)]
    public string Purpose { get; set; } = string.Empty;
}
