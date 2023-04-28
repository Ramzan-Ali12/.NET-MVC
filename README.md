# .NET-MVC
# .NET CRUD

.NET CRUD is a simple web application that allows you to create, read, update and delete data from a database using .NET framework.

## Installation

To install .NET CRUD, you need to have .NET SDK and SQL Server installed on your system. Then follow these steps:

1. Clone this repository to your local machine: `https://github.com/Ramzan-Ali12/.NET-MVC.git`
2. Navigate to the project directory: `cd dotnet-crud`
3. Restore the dependencies: `dotnet restore`
4. Update the connection string in the appsettings.json file with your database credentials
5. Run the database migrations: `dotnet ef database update`
6. Start the development server: `dotnet run`

## Usage

To use .NET CRUD, open your browser and go to http://localhost:5000. You will see a list of data from the database. You can add a new record by clicking on the "Create" button, edit an existing record by clicking on the "Edit" button, or delete a record by clicking on the "Delete" button.

![Capture](https://user-images.githubusercontent.com/103037323/215186886-b191899a-9fc4-428d-835c-a670052f5658.PNG)

## Features

.NET CRUD has the following features:

- Create, read, update and delete data from a database using .NET framework
- Validate user input and display error messages
- Use Bootstrap for styling and layout
- Use Entity Framework Core for database interaction
- Use Razor Pages for views

## Contributing

.NET CRUD is an open source project and welcomes contributions from anyone. If you want to contribute to .NET CRUD, please follow these guidelines:

- Fork this repository and create a new branch for your feature or bug fix
- Write clean and consistent code that follows the C# coding conventions
- Test your code locally before pushing to GitHub
- Create a pull request with a clear description of your changes
- Wait for feedback or approval from the maintainer
