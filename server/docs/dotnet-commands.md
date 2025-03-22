# Dot Net Command Log

## Initial dotnet setup steps

```sh
git clone git@github.com:koreyhinton/designbox

cd designbox/server

dotnet new sln --name Blueprints

dotnet new classlib -n BlueprintsDataModel
dotnet new console -n BlueprintsConsoleApp

cd ..

dotnet sln add src/BlueprintsConsoleApp/BlueprintsConsoleApp.csproj
dotnet sln Blueprints.sln add src/BlueprintsDataModel/BlueprintsDataModel.csproj
dotnet add package Microsoft.EntityFrameworkCore.Design
```

## Add initial packages

```sh

cd src/BlueprintsDataModel/

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design

cd ../..

dotnet build  # server dir
dotnet run --project src/BlueprintsConsoleApp

```
