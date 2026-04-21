using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TeamDirectoryApi.Data;

#nullable disable

namespace TeamDirectoryApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.25");

            modelBuilder.Entity("TeamDirectoryApi.Models.BreakfastFood", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int>("Calories")
                    .HasColumnType("INTEGER");

                b.Property<string>("DrinkPairing")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("FoodName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<bool>("IsSweet")
                    .HasColumnType("INTEGER");

                b.Property<string>("MainIngredient")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("BreakfastFoods");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Calories = 350,
                        DrinkPairing = "Coffee",
                        FoodName = "Pancakes",
                        IsSweet = true,
                        MainIngredient = "Flour"
                    },
                    new
                    {
                        Id = 2,
                        Calories = 280,
                        DrinkPairing = "Orange Juice",
                        FoodName = "Omelet",
                        IsSweet = false,
                        MainIngredient = "Eggs"
                    },
                    new
                    {
                        Id = 3,
                        Calories = 250,
                        DrinkPairing = "Tea",
                        FoodName = "Bagel",
                        IsSweet = false,
                        MainIngredient = "Bread"
                    },
                    new
                    {
                        Id = 4,
                        Calories = 330,
                        DrinkPairing = "Milk",
                        FoodName = "French Toast",
                        IsSweet = true,
                        MainIngredient = "Bread"
                    },
                    new
                    {
                        Id = 5,
                        Calories = 220,
                        DrinkPairing = "Water",
                        FoodName = "Yogurt Bowl",
                        IsSweet = true,
                        MainIngredient = "Yogurt"
                    });
            });

            modelBuilder.Entity("TeamDirectoryApi.Models.Hobby", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Category")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.Property<string>("HobbyName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("IndoorOrOutdoor")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("TEXT");

                b.Property<string>("Notes")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("TEXT");

                b.Property<string>("SkillLevel")
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Hobbies");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Category = "Fitness",
                        HobbyName = "Running",
                        IndoorOrOutdoor = "Outdoor",
                        Notes = "Runs local parks on weekends",
                        SkillLevel = "Intermediate"
                    },
                    new
                    {
                        Id = 2,
                        Category = "Entertainment",
                        HobbyName = "Gaming",
                        IndoorOrOutdoor = "Indoor",
                        Notes = "Likes multiplayer games",
                        SkillLevel = "Advanced"
                    },
                    new
                    {
                        Id = 3,
                        Category = "Food",
                        HobbyName = "Cooking",
                        IndoorOrOutdoor = "Indoor",
                        Notes = "Trying easy pasta recipes",
                        SkillLevel = "Beginner"
                    },
                    new
                    {
                        Id = 4,
                        Category = "Creative",
                        HobbyName = "Photography",
                        IndoorOrOutdoor = "Outdoor",
                        Notes = "Focus on nature photos",
                        SkillLevel = "Intermediate"
                    },
                    new
                    {
                        Id = 5,
                        Category = "Fitness",
                        HobbyName = "Weightlifting",
                        IndoorOrOutdoor = "Indoor",
                        Notes = "Works out four times a week",
                        SkillLevel = "Intermediate"
                    });
            });

            modelBuilder.Entity("TeamDirectoryApi.Models.StudyTool", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Category")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.Property<bool>("IsFree")
                    .HasColumnType("INTEGER");

                b.Property<string>("Platform")
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("TEXT");

                b.Property<string>("Purpose")
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnType("TEXT");

                b.Property<string>("ToolName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("StudyTools");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Category = "IDE",
                        IsFree = true,
                        Platform = "Desktop",
                        Purpose = "Writing and debugging C# code",
                        ToolName = "Visual Studio"
                    },
                    new
                    {
                        Id = 2,
                        Category = "Version Control",
                        IsFree = true,
                        Platform = "Web",
                        Purpose = "Hosting code and tracking commits",
                        ToolName = "GitHub"
                    },
                    new
                    {
                        Id = 3,
                        Category = "Notes",
                        IsFree = true,
                        Platform = "Web",
                        Purpose = "Organizing assignments and notes",
                        ToolName = "Notion"
                    },
                    new
                    {
                        Id = 4,
                        Category = "API Testing",
                        IsFree = true,
                        Platform = "Desktop",
                        Purpose = "Testing API endpoints",
                        ToolName = "Postman"
                    },
                    new
                    {
                        Id = 5,
                        Category = "Diagramming",
                        IsFree = true,
                        Platform = "Web",
                        Purpose = "Making ERDs and flowcharts",
                        ToolName = "Draw.io"
                    });
            });

            modelBuilder.Entity("TeamDirectoryApi.Models.TeamMember", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("Birthdate")
                    .HasColumnType("TEXT");

                b.Property<string>("CollegeProgram")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("FullName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("YearInProgram")
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("TeamMembers");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Birthdate = new DateTime(2003, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        CollegeProgram = "Information Technology",
                        FullName = "Alex Carter",
                        YearInProgram = "Sophomore"
                    },
                    new
                    {
                        Id = 2,
                        Birthdate = new DateTime(2002, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        CollegeProgram = "Cybersecurity",
                        FullName = "Jordan Miller",
                        YearInProgram = "Junior"
                    },
                    new
                    {
                        Id = 3,
                        Birthdate = new DateTime(2004, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        CollegeProgram = "Software Development",
                        FullName = "Taylor Brooks",
                        YearInProgram = "Freshman"
                    },
                    new
                    {
                        Id = 4,
                        Birthdate = new DateTime(2001, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        CollegeProgram = "Database Administration",
                        FullName = "Morgan Reed",
                        YearInProgram = "Senior"
                    },
                    new
                    {
                        Id = 5,
                        Birthdate = new DateTime(2003, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                        CollegeProgram = "Networking",
                        FullName = "Casey Bennett",
                        YearInProgram = "Sophomore"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}
