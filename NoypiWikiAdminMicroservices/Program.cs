using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Interface;
using NoypiWikiAdminInfrastructure;
using NoypiWikiAdminInfrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IUserEntityRepository, UserEntityRepository>();

builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
    .AddJsonFile("appsettings.Production.json", optional: true, reloadOnChange: true);

builder.Services.AddDbContext<NoypiWikiDbContext>(options => 
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnectionString"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnectionString")),
        b => b.MigrationsAssembly("NoypiWikiAdminMicroservices"))
);

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<NoypiWikiDbContext>();
    db.Database.Migrate();
}

app.MapGet("/", () => "Not Allowed");
app.MapControllers();
app.Run();