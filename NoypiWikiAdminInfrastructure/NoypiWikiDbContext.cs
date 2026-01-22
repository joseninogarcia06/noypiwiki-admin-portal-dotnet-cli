using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models;
namespace NoypiWikiAdminInfrastructure;
public class NoypiWikiDbContext : DbContext
{
    public NoypiWikiDbContext(DbContextOptions<NoypiWikiDbContext> options) : base(options)
    {}

    public DbSet<User> User { get; set; }

    public DbSet<Staff> Staff { get; set; }
}
