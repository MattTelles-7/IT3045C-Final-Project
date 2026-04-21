# IT3045C Final Project

### Commands to run

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
