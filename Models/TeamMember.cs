using System.ComponentModel.DataAnnotations;

namespace TeamDirectoryApi.Models;

public class TeamMember
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = string.Empty;

    public DateTime Birthdate { get; set; }

    [Required]
    [MaxLength(100)]
    public string CollegeProgram { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string YearInProgram { get; set; } = string.Empty;
}
