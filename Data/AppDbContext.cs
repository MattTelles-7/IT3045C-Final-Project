using Microsoft.EntityFrameworkCore;
using TeamDirectoryApi.Models;

namespace TeamDirectoryApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<TeamMember> TeamMembers => Set<TeamMember>();
    public DbSet<Hobby> Hobbies => Set<Hobby>();
    public DbSet<BreakfastFood> BreakfastFoods => Set<BreakfastFood>();
    public DbSet<StudyTool> StudyTools => Set<StudyTool>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TeamMember>().HasData(
            new TeamMember { Id = 1, FullName = "Alex Carter", Birthdate = new DateTime(2003, 1, 15), CollegeProgram = "Information Technology", YearInProgram = "Sophomore" },
            new TeamMember { Id = 2, FullName = "Jordan Miller", Birthdate = new DateTime(2002, 5, 24), CollegeProgram = "Cybersecurity", YearInProgram = "Junior" },
            new TeamMember { Id = 3, FullName = "Taylor Brooks", Birthdate = new DateTime(2004, 8, 9), CollegeProgram = "Software Development", YearInProgram = "Freshman" },
            new TeamMember { Id = 4, FullName = "Morgan Reed", Birthdate = new DateTime(2001, 11, 2), CollegeProgram = "Database Administration", YearInProgram = "Senior" },
            new TeamMember { Id = 5, FullName = "Casey Bennett", Birthdate = new DateTime(2003, 3, 30), CollegeProgram = "Networking", YearInProgram = "Sophomore" }
        );

        modelBuilder.Entity<Hobby>().HasData(
            new Hobby { Id = 1, HobbyName = "Running", Category = "Fitness", IndoorOrOutdoor = "Outdoor", SkillLevel = "Intermediate", Notes = "Runs local parks on weekends" },
            new Hobby { Id = 2, HobbyName = "Gaming", Category = "Entertainment", IndoorOrOutdoor = "Indoor", SkillLevel = "Advanced", Notes = "Likes multiplayer games" },
            new Hobby { Id = 3, HobbyName = "Cooking", Category = "Food", IndoorOrOutdoor = "Indoor", SkillLevel = "Beginner", Notes = "Trying easy pasta recipes" },
            new Hobby { Id = 4, HobbyName = "Photography", Category = "Creative", IndoorOrOutdoor = "Outdoor", SkillLevel = "Intermediate", Notes = "Focus on nature photos" },
            new Hobby { Id = 5, HobbyName = "Weightlifting", Category = "Fitness", IndoorOrOutdoor = "Indoor", SkillLevel = "Intermediate", Notes = "Works out four times a week" }
        );

        modelBuilder.Entity<BreakfastFood>().HasData(
            new BreakfastFood { Id = 1, FoodName = "Pancakes", IsSweet = true, MainIngredient = "Flour", Calories = 350, DrinkPairing = "Coffee" },
            new BreakfastFood { Id = 2, FoodName = "Omelet", IsSweet = false, MainIngredient = "Eggs", Calories = 280, DrinkPairing = "Orange Juice" },
            new BreakfastFood { Id = 3, FoodName = "Bagel", IsSweet = false, MainIngredient = "Bread", Calories = 250, DrinkPairing = "Tea" },
            new BreakfastFood { Id = 4, FoodName = "French Toast", IsSweet = true, MainIngredient = "Bread", Calories = 330, DrinkPairing = "Milk" },
            new BreakfastFood { Id = 5, FoodName = "Yogurt Bowl", IsSweet = true, MainIngredient = "Yogurt", Calories = 220, DrinkPairing = "Water" }
        );

        modelBuilder.Entity<StudyTool>().HasData(
            new StudyTool { Id = 1, ToolName = "Visual Studio", Category = "IDE", Platform = "Desktop", IsFree = true, Purpose = "Writing and debugging C# code" },
            new StudyTool { Id = 2, ToolName = "GitHub", Category = "Version Control", Platform = "Web", IsFree = true, Purpose = "Hosting code and tracking commits" },
            new StudyTool { Id = 3, ToolName = "Notion", Category = "Notes", Platform = "Web", IsFree = true, Purpose = "Organizing assignments and notes" },
            new StudyTool { Id = 4, ToolName = "Postman", Category = "API Testing", Platform = "Desktop", IsFree = true, Purpose = "Testing API endpoints" },
            new StudyTool { Id = 5, ToolName = "Draw.io", Category = "Diagramming", Platform = "Web", IsFree = true, Purpose = "Making ERDs and flowcharts" }
        );
    }
}
