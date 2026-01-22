using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminInfrastructure.EntityConfiguration;

public class UserEntityConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder
            .HasKey(x => x.ID);

        builder
            .Property(x => x.UserId)
            .IsRequired(true);

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
