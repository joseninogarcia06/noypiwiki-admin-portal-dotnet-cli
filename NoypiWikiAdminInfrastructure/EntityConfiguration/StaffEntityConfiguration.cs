using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminInfrastructure.EntityConfiguration;

public class StaffEntityConfiguration : IEntityTypeConfiguration<StaffEntity>
{
    public void Configure(EntityTypeBuilder<StaffEntity> builder)
    {
        builder
            .HasKey(x => x.ID);

        builder
            .Property(x => x.FirstName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(x => x.MiddleName)
            .IsRequired(false)
            .HasMaxLength(50);

        builder
            .Property(x => x.LastName)
            .IsRequired(true)
            .HasMaxLength(50);

        builder
            .Property(x => x.ContactNumber)
            .IsRequired(false)
            .HasMaxLength(30);

        builder
            .Property(x => x.EmailAddress)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.Property(x => x.StaffStatusId)
               .IsRequired(true);
    }
}
