using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminInfrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

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