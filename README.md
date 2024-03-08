# Project Name - Database Setup Guide

This guide provides instructions on setting up the database for the [Project Name] project.

## Prerequisites

- Microsoft SQL Server Management Studio (SSMS) or a similar SQL Server management tool.
- .NET Core SDK installed on your machine.
- Basic knowledge of SQL Server and .NET Core application development.

## Database Setup

### Step 1: Create Database

1. Open SQL Server Management Studio (SSMS).
2. Connect to your SQL Server instance.
3. In the Object Explorer, right-click on Databases and select "New Database".
4. Enter a name for your database (e.g., [DatabaseName]) and click "OK".

### Step 2: Run Database Script

1. Locate the SQL script file for creating database tables and other objects. The script is typically located in the `.scripts` folder of the project.
2. Open the script file in SQL Server Management Studio.
3. Select the database you created in Step 1 from the dropdown in the toolbar.
4. Execute the script by clicking the "Execute" button or pressing F5. This will create the necessary tables and other objects in your database.

### Step 3: Modify Connection String

1. Navigate to the `appsettings.json` file in your project.
2. Locate the section named `ConnectionStrings`.
3. Update the `DefaultConnection` string with the connection details for your SQL Server instance. Modify the Server, Database, User ID, and Password fields as necessary.
Example:
```json
"ConnectionStrings": {
    "DefaultConnection": "Server=YourServer;Database=YourDatabase;User ID=YourUserID;Password=YourPassword;"
}
```
### Step 4: Running the Razor Application

1. Open the project in Visual Studio or your preferred IDE.
2. Build the project to ensure all dependencies are resolved.
3. Press F5 or select the "Start" button to run the Razor application.
4. The application should launch in your default web browser, displaying the homepage or login page.

