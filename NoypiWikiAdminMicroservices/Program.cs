using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using NoypiWikiAdminDomain.Interface;
using NoypiWikiAdminInfrastructure;
using NoypiWikiAdminInfrastructure.Repository;
using NoypiWikiAdminMicroservices.Interface.Admin;
using NoypiWikiAdminMicroservices.Services.Admin;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IUserEntityRepository, UserEntityRepository>();
builder.Services.AddScoped<IUserAuthenticateService, UserAuthenticateService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "NoypiWiki Microservices", Version = "v1" });
});

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

if (app.Environment.IsStaging())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    });   
}

app.MapGet("/", () => "Not Allowed");
app.MapControllers();
app.Run();