# Simple-Crud-Asp-Net
This is a simple CRUD web page developed using Asp.Net Core, Bootstrap library and a Northwind based Database.

In order to run the project, you must have a SQL server running in your machine.

Open appsettings.json file, and in "DataBase" field insert your database server name.

If you are using Windows Authentication on your SQL server, you should only change server name in the file, otherwise, you have to use the following pattern in "DataBase" field: "DataBase": "Server={your-database-server-name};Database=DB_Northwind-Like;User Id={your-database-server-user};Password={your-database-server-password}"

Open the Package Manager Console and type the following instructions: 
  Add-Migration CreatingNorthwindDataBase -Context ContextDataBase
  Update-Database -Context ContextDataBase
  
Now you're able to run the project and check the CRUD web page.
