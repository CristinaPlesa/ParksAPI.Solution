# Park API

#### By Cristina Plesa

#### A C# application that uses a built in API database for National and State parks.

## Technologies Used

* C#
* Entity Framework
* .NET 5 SDK
* VS Code
* MySQL Workbench
* Swagger through Swashbuckle
* License
* MIT License.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to set up and run the project
- MySQL 8.0.19, following [these pinned installation instructions](https://web.archive.org/web/20210521163651/https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)
- A web browser to view and interact with the project

### Installation

1. Clone the repository: `$ git clone https://github.com/CristinaPlesa/ParksAPI.Solution.git`
2. Navigate to the `ParksAPI` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:

   - Create an `appsettings.json` file in the `ParksAPI` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:

   ```
   {
   "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
   },
   "AllowedHosts": "*"
    { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=park_api;uid=root;pwd=YourPassword;" } }
   }
   ```

5. To serve the local web app:

- Navigate to `ParksAPI.Solution/ParksAPI` in your command line
- Run the commands:
  - `dotnet restore` to restore the dependencies that are listed in `ParksAPI.csproj`
  - `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
  - `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
  - `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
  - `dotnet build` to build the project and its dependencies into a set of binaries
  - `dotnet tool install --global dotnet-ef` to install EF Core tools
  - `dotnet ef database update`
- Finally, run the command `dotnet run` to run the project!
- Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app

6. Visit the application via web browser at: `localhost:5000/`
7. To check the Swagger API documentation, you can also go to `http://localhost:5000/swagger` in the browser

## Known Bugs

* No known bugs

## License

[MIT](https://opensource.org/licenses/MIT) Copyright (c) 2021 Cristina Plesa

## Contact Information

Please reach out through my GitHub account.
[github.com/CristinaPlesa](https://github.com/CristinaPlesa)