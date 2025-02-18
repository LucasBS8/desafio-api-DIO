https://github.com/digitalinnovationone/trilha-net-api-desafio.git
https://github.com/LucasBS8/treino_Api_CSharp.git
dotnet new webapi --use-controllers
dotnet new webapi --use-controllers --framework net8.0
dotnet tool install --global  dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Swashbuckle.AspNetCore

dotnet ef migrations add InitialCreate
dotnet ef database update

dotnet watch run