## Migrations
 

create migration
dotnet ef migrations add Initial --project .\PointOfSaleDataAccess 

run migration
dotnet ef database update  --project .\PointOfSaleDataAccess

remove last migration
dotnet ef migrations remove --project .\PointOfSaleDataAccess
