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

        builder
            .Property(x => x.Username)
            .IsRequired(true)
            .HasMaxLength(30);

        builder
            .Property(x => x.FirstName)
            .IsRequired(false)
            .HasMaxLength(50);

        builder
            .Property(x => x.MiddleName)
            .IsRequired(false)
            .HasMaxLength(50);

        builder
            .Property(x => x.LastName)
            .IsRequired(false)
            .HasMaxLength(50);

        builder
            .Property(x => x.EmailAddress)
            .IsRequired(false)
            .HasMaxLength(50);

        builder
            .Property(x => x.CreatedOn)
            .IsRequired(true);

        builder
            .Property(x => x.CreatedBy)
            .IsRequired(true);

        builder
            .Property(x => x.CreatedByType)
            .IsRequired(true);

        builder
            .Property(x => x.CreatedByType)
            .IsRequired(true);

        builder
            .Property(x => x.ModifiedOn)
            .IsRequired(true);

        builder
            .Property(x => x.ModifiedBy)
            .IsRequired(true);

        builder
            .Property(x => x.ModifiedByType)
            .IsRequired(true);

        builder
            .Property(x => x.IsActive)
            .IsRequired(true);
    }
}
