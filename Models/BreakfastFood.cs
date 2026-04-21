using System.ComponentModel.DataAnnotations;

namespace TeamDirectoryApi.Models;

public class BreakfastFood
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string FoodName { get; set; } = string.Empty;

    public bool IsSweet { get; set; }

    [Required]
    [MaxLength(50)]
    public string MainIngredient { get; set; } = string.Empty;

    public int Calories { get; set; }

    [MaxLength(100)]
    public string DrinkPairing { get; set; } = string.Empty;
}
