using System.ComponentModel.DataAnnotations;

namespace TeamDirectoryApi.Models;

public class Hobby
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string HobbyName { get; set; } = string.Empty;

    [Required]
    [MaxLength(50)]
    public string Category { get; set; } = string.Empty;

    [Required]
    [MaxLength(20)]
    public string IndoorOrOutdoor { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string SkillLevel { get; set; } = string.Empty;

    [MaxLength(200)]
    public string Notes { get; set; } = string.Empty;
}
