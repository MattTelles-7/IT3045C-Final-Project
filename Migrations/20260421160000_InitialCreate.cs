using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using TeamDirectoryApi.Data;

#nullable disable

namespace TeamDirectoryApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260421160000_InitialCreate")]
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreakfastFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsSweet = table.Column<bool>(type: "INTEGER", nullable: false),
                    MainIngredient = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    DrinkPairing = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastFoods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HobbyName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IndoorOrOutdoor = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    SkillLevel = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyTools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ToolName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Platform = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    IsFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    Purpose = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyTools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Birthdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CollegeProgram = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    YearInProgram = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BreakfastFoods",
                columns: new[] { "Id", "Calories", "DrinkPairing", "FoodName", "IsSweet", "MainIngredient" },
                values: new object[,]
                {
                    { 1, 350, "Coffee", "Pancakes", true, "Flour" },
                    { 2, 280, "Orange Juice", "Omelet", false, "Eggs" },
                    { 3, 250, "Tea", "Bagel", false, "Bread" },
                    { 4, 330, "Milk", "French Toast", true, "Bread" },
                    { 5, 220, "Water", "Yogurt Bowl", true, "Yogurt" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "HobbyName", "IndoorOrOutdoor", "Notes", "SkillLevel" },
                values: new object[,]
                {
                    { 1, "Fitness", "Running", "Outdoor", "Runs local parks on weekends", "Intermediate" },
                    { 2, "Entertainment", "Gaming", "Indoor", "Likes multiplayer games", "Advanced" },
                    { 3, "Food", "Cooking", "Indoor", "Trying easy pasta recipes", "Beginner" },
                    { 4, "Creative", "Photography", "Outdoor", "Focus on nature photos", "Intermediate" },
                    { 5, "Fitness", "Weightlifting", "Indoor", "Works out four times a week", "Intermediate" }
                });

            migrationBuilder.InsertData(
                table: "StudyTools",
                columns: new[] { "Id", "Category", "IsFree", "Platform", "Purpose", "ToolName" },
                values: new object[,]
                {
                    { 1, "IDE", true, "Desktop", "Writing and debugging C# code", "Visual Studio" },
                    { 2, "Version Control", true, "Web", "Hosting code and tracking commits", "GitHub" },
                    { 3, "Notes", true, "Web", "Organizing assignments and notes", "Notion" },
                    { 4, "API Testing", true, "Desktop", "Testing API endpoints", "Postman" },
                    { 5, "Diagramming", true, "Web", "Making ERDs and flowcharts", "Draw.io" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Birthdate", "CollegeProgram", "FullName", "YearInProgram" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Alex Carter", "Sophomore" },
                    { 2, new DateTime(2002, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cybersecurity", "Jordan Miller", "Junior" },
                    { 3, new DateTime(2004, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software Development", "Taylor Brooks", "Freshman" },
                    { 4, new DateTime(2001, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database Administration", "Morgan Reed", "Senior" },
                    { 5, new DateTime(2003, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Networking", "Casey Bennett", "Sophomore" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "BreakfastFoods");
            migrationBuilder.DropTable(name: "Hobbies");
            migrationBuilder.DropTable(name: "StudyTools");
            migrationBuilder.DropTable(name: "TeamMembers");
        }

        protected override void BuildTargetModel(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
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
