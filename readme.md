```dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.InMemory```

generate code
 - dotnet aspnet-codegenerator controller -name UserController -async -api -m User -dc ApplicationDbContext -outDir Controllers
