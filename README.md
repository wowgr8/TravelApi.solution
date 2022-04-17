Travel API ™️
An API for TRAVEL. A user may View List, Add, Edit, and Delete Destinations as needed and interact with the the API using Postman.



Authored by Cesar Lopez, Chris Nakayama, Wajima Niazi, Ebru Rice, Amber Wilwand
Technologies Used
C#
MySQL
My SQL Workbench
VS Code
Git BASH
LINQ
ASP .NET CORE MVC
Entity Framework Core
Postman
Swagger
Swashbuckle
Setup/Installation Requirements
Download or clone the repo here: (ADDRESS REPO HERE)
to your local machine

Open git BASH terminal and navigate to the AnimalShelter folder within the directory

Create appsettings.json file in the Factory directory of AnimalShelter.Solution and add the following code to the file: touch appsettings.json

{
  "Logging":
  {
    "LogLevel":
    {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings":
  {
    "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
  }
}
Be sure to remove the {YOUR_USERNAME_NAME} and {YOUR_PASSWORD} and fill in the the code snippet with your username for MySQL, and MySQL password Do not include the curly brackets in your code snippet of appsettings.json

Make sure EF Core is installed to create and utilize migrations. Run the following code in the git BASH terminal to install. $ dotnet tool install --global dotnet-ef --version 3.0.0

Run "dotnet restore" in the git BASH terminal to install needed dependencies. $ dotnet restore

Run "dotnet build" in the git BASH terminal to minify the code. $ dotnet build

Run "dotnet ef database update" in the git BASH terminal create the database outlined from the Model within the project. $ dotnet ef database update

Run "dotnet run" in the git BASH terminal to minify the code, and run the project in the terminal. $ dotnet watch run

View the API by downloading Postman and entering http://localhost:5000/api/cats or http://localhost:5000/api/dogs as a GET!

API Documentation
API Endpoints
HTTP Request URL: http://localhost:5000
General request structure:
GET /api/Cats
POST /api/Cats
GET /api/Cats/{id}
PUT /api/Cats/{id}
DELETE /api/Cats/{id} 
substitute Cats with Dogs or SmallAnimals depending on the intended query results
examples of a request URL query string:
https://localhost:5001/api/Cats?name=Kimmy
https://localhost:5001/api/Dogs?name=Muffin
https://localhost:5001/api/SmallAnimals?name=Bacon
Documentation utilized for further explorations:
<!-- CORS source: infoworld
CORS source: microsoft docs
Pagination source: c-sharpcorner
Pagination source: jasonwatmore
Unique constraints to avoid duplicates source: stack overflow -->
Swagger source: microsoft docs
Swagger utilizing Swashbuckle source: microsoft docs -->
Bugs
no known bugs at this time

License
MIT & AFL

Copyright ©️ 2021 

if any issues are discovered while navigating the site, please let me know! It will help me learn and grow!

Contact Information
