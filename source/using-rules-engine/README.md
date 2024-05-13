# Code first EF Core
- Create DB Context
- Add migration
    > add-migration InitialRulesDB
    > or
    > dotnet ef migrations add InitialRulesDB`

- Create DB in server
    > dotnet ef database update
    > or
    > update-database -verbose

- Support Commands: 
    > dotnet ef migrations list
    > dotnet ef migrations remove
    > dotnet ef migrations script
    > or
    > Get-Migration
    > remove-migration
    > generate-script