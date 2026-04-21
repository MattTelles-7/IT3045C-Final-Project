# IT3045C Final Project

This is the minimum ASP.NET Core Web API needed to match the assignment:

- .NET 10 Web API
- Entity Framework Core with SQLite
- Code-first models and migrations
- Seed data
- 4 controllers and 4 tables
- CRUD on every controller
- NSwag UI for testing at `/swagger`

# Commands to run

Run these from the repo root:

```bash
dotnet restore TeamDirectoryApi.csproj
dotnet tool restore
dotnet tool run dotnet-ef database update --project TeamDirectoryApi.csproj
dotnet run --project TeamDirectoryApi.csproj
```

Then open:

```text
http://localhost:5099/swagger
```

If you see `NU1900` warnings about `/Users/christophertelles/.local/share/NuGet`, that is a local machine permission warning and does not stop the project from building or running.
