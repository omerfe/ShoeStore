# ShoeStore

### Project Structure
```
\src
* ApplicationCore
* Infrastructure
* Web

\tests
* UnitTests
```

### Migrations
```
/Infrastructure
Add-Migration InitialCreate -Context StoreContext -OutputDir "Data/Migrations"
Update-Database -Context StoreContext
Add-Migration InitialCreate -Context AppIdentityDbContext -OutputDir "Identity/Migrations"
Update-Database -Context AppIdentityDbContext
```

### Packages
```
\ApplicationCore
Install-Package Ardalis.Specification -v 5.2.0

\Infrastructure
Install-Package Microsoft.EntityFrameworkCore -v 5.0.14
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -v 5.0.10
Install-Package Ardalis.Specification.EntityFrameworkCore -v 5.2.0
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.14
```
### Resources

* https://github.com/yigith/TechMarket
* https://github.com/dotnet-architecture/eShopOnWeb
* https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-5.0#localization-middleware
* https://gist.github.com/yigith/c6f999788b833dc3d22ac6332a053dd1
* https://docs.microsoft.com/en-us/aspnet/core/fundamentals/http-context?view=aspnetcore-5.0
* https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-5.0#dictionaries-1
* https://github.com/dotnet/aspnetcore/issues/16663
* https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.modelbinderattribute.name?view=aspnetcore-5.0
* https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-5.0
* https://getbootstrap.com/docs/5.1/examples/checkout/
* https://docs.microsoft.com/en-us/aspnet/core/mvc/views/view-components?view=aspnetcore-5.0#walkthrough-creating-a-simple-view-component