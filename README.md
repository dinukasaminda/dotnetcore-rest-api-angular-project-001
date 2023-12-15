# dotnetcore-rest-api-angular-project-001

DotNet core web api with angular frontend , ecommerce application

Swagger Link : https://localhost:7196/swagger/index.html

## Layered Architecture

Layerd Projets, Seperation of concern , seperating Controllers,Models, Services

## Repository Pattern

## Dependency Injection

### Using Add Transient

Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.

### Using Add Scoped

Scoped lifetime services are created once per request.

### Using Add Singleton

Singleton lifetime services are created the first time they are requested (or when ConfigureServices is run if you specify an instance there) and then every subsequent request will use the same instance.

## SQL Server docker composer file

```
version: "3"
services:
  sql-server:
    image: mcr.microsoft.com/mssql/server:latest
    environment:
      ACCEPT_EULA: "Y"
      SA_PASSWORD: "tSDIN-TD_12556"
    ports:
      - 1433:1433

```

## SQL Azure Data studio

Azure Data studio use to explore SQL Server databases
Link : https://azure.microsoft.com/en-us/products/data-studio

## Install Dependencies

1.  EntityFreamwork
2.  EntityFreamwork Design
3.  EntityFreamwork SQLSever

## Install EntityFreamwork Tool CLI

```
dotnet tool install --global dotnet-ef
```

## DB Migrations [Code First]:

```
 Create Migration:   dotnet ef migrations add Initial --project DemoRestApi.Persistence
 Run Migration:   dotnet ef database update --project DemoRestApi.Persistence

```

## SQL Connection String:

```
var connectionString = "Server=localhost,1433; Database=MyTodoDb; User=sa; Password=tSDIN-TD_12556;TrustServerCertificate=True";
```
