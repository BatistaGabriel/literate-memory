# literate-memory

This is a sample ASP.NET Core application created using GitHub Codespaces, which means everything here was created using the dotnet CLI instead of using the guardrails of project creation via Visual Studio.

This is an attempt to build and provide a functional project that can run in environments where installing Visual Studio might not be feasible, but using dotnet to build/maintain a project is necessary.

## Commands

### Creating the project files:

```bash
$ mkdir MyApp
$ cd MyApp/
$ dotnet new sln -n MyApp
$ mkdir src tests
$ dotnet new mvc -n MyApp.Web -o src/MyApp.Web -f net8.0
$ dotnet new classlib -n MyApp.Core -o src/MyApp.Core -f net8.0
$ dotnet new xunit -n MyApp.Tests -o tests/MyApp.Tests -f net8.0
$ dotnet sln add src/MyApp.Web/MyApp.Web.csproj --solution-folder "Web"
$ dotnet sln add src/MyApp.Core/MyApp.Core.csproj --solution-folder "Libraries"
$ dotnet sln add tests/MyApp.Tests/MyApp.Tests.csproj --solution-folder "Tests"
$ dotnet add src/MyApp.Web/MyApp.Web.csproj reference src/MyApp.Core/MyApp.Core.csproj
$ dotnet add src/MyApp.Core package Microsoft.EntityFrameworkCore
$ dotnet add src/MyApp.Web package Swashbuckle.AspNetCore
```

### Checking references and removing projects:

```bash
$ dotnet sln list
$ dotnet list src/MyApp.Web/MyApp.Web.csproj reference
$ dotnet remove src/MyApp.Web/MyApp.Web.csproj reference src/MyApp.Core/MyApp.Core.csproj
$ dotnet sln remove src/MyApp.Core/MyApp.Core.csproj
$ rm -rf src/MyApp.Core
$ dotnet sln list
$ dotnet build
```

### Running the project:

```bash
$ dotnet watch run --project src/MyApp.Web/
```

### Creating a new class file:

```bash
$ dotnet new class -o src/MyApp.Web/Models -n Item
```

### Creating a new MVC controller file:

```bash
$ dotnet new mvccontroller -o src/MyApp.Web/Controllers -n ItemsController
```

### Creating a new view:

```bash
$ mkdir src/MyApp.Web/Views/Items
$ dotnet new view -o src/MyApp.Web/Views/Items -n Overview
```
