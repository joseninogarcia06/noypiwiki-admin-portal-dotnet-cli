using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models;
namespace NoypiWikiAdminInfrastructure;
public class NoypiWikiDbContext : DbContext
{
    public NoypiWikiDbContext(DbContextOptions<NoypiWikiDbContext> options) : base(options)
    {}

    public DbSet<UserEntity> User { get; set; }

    public DbSet<StaffEntity> Staff { get; set; }

    public DbSet<MemberEntity> Members { get; set; }

    public DbSet<StaffStatusEntity> StaffStatus { get; set; }
}
