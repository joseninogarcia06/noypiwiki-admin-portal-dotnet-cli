using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

[Index(nameof(CreatedOn), nameof(ModifiedOn), nameof(UserId))]
public class UserEntity : BaseEntity
{
    public Guid UserId { get; set; }

    public UserEntity()
    {}

    public UserEntity(Guid userId, string createdBy, string createdByType, string modifiedBy, 
                string modifiedByType)
    {
        this.ID = Guid.NewGuid();
        this.UserId = userId;
        this.CreatedOn = DateTimeOffset.Now;
        this.CreatedBy = createdBy;
        this.CreatedByType = createdByType;
        this.ModifiedOn = DateTimeOffset.Now;
        this.ModifiedBy = modifiedBy;
        this.ModifiedByType = modifiedByType;
        this.IsActive = true;
    }
}
