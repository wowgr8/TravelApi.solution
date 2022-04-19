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

Open git BASH terminal and navigate to the TravelApi folder within the directory

Create appsettings.json file in the TravelApi directory of TravelApi.Solution-Main and add the following code to the file: touch appsettings.json

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
    "DefaultConnection": "Server=localhost;Port=3306;database=travel_api;uid=root;pwd=epicodus;"
  }
}
Be sure to remove the {YOUR_USERNAME_NAME} and {YOUR_PASSWORD} and fill in the the code snippet with your username for MySQL, and MySQL password Do not include the curly brackets in your code snippet of appsettings.json

Make sure EF Core is installed to create and utilize migrations. Run the following code in the git BASH terminal to install. $ dotnet tool install --global dotnet-ef --version 

Run "dotnet restore" in the git BASH terminal to install needed dependencies. $ dotnet restore

Run "dotnet build" in the git BASH terminal to minify the code. $ dotnet build

Run "dotnet ef database update" in the git BASH terminal create the database outlined from the Model within the project. $ dotnet ef database update

Run "dotnet run" in the git BASH terminal to minify the code, and run the project in the terminal. $ dotnet watch run

View the API by downloading Postman and entering http://localhost:5000/api/cats or http://localhost:5000/api/dogs as a GET!

API Documentation
API Endpoints
HTTP Request URL: http://localhost:5000
General request structure:
GET /api/Destinations
POST /api/Destinations
GET /api/Destinations/{id}
PUT /api/Destinations/{id}
DELETE /api/Destinations/{id} 

examples of a request URL query string:
https://localhost:5001/api/Destinations

Documentation utilized for further explorations:
Swagger source: microsoft docs
Swagger utilizing Swashbuckle source: microsoft docs -->

Bugs
no known bugs at this time

License
MIT & AFL

Copyright ©️ 2021 

if any issues are discovered while navigating the site, please let us know! It will help me learn and grow!

Contact Information: cnakayam@gmail.com
