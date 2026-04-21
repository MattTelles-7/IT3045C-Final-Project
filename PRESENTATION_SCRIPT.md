# Bare minimum presentation script

## Person 1 - intro
"Hi, our project is a .NET 8 ASP.NET Core Web API. We used Entity Framework Core with the code-first approach, SQLite for the database, and NSwag so we could document and test the API in Swagger."

## Person 2 - models / database
"Our API has four tables: TeamMembers, Hobbies, BreakfastFoods, and StudyTools. Each table has at least five columns including the primary key. We also included seed data and a migrations folder so the database can be created from the project."

## Person 3 - controllers / CRUD
"Each table has its own controller, and every controller supports full CRUD operations: create, read, update, and delete. For the read method, if the id is missing or zero, the controller returns the first five records, which matches the assignment requirements."

## Person 4 - demo / git
"Here we are testing the endpoints in NSwag through Swagger UI. We can see each controller, run the requests, and confirm the API works. We also used GitHub as version control, and each team member made at least one commit to the project."

## Ending line
"That is our final project. Thank you."
