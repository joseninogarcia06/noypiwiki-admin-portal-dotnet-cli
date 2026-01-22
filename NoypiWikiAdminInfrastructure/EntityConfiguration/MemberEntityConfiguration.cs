using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminInfrastructure.EntityConfiguration;

public class MemberEntityConfiguration : IEntityTypeConfiguration<MemberEntity>
{
    public void Configure(EntityTypeBuilder<MemberEntity> builder)
    {
        builder
            .HasKey(x => x.ID);
    }
}
