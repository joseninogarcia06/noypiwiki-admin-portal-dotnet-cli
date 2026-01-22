using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

[Index(nameof(CreatedOn), nameof(ModifiedOn))]
public class StaffEntity : BaseEntity
{
    public Guid UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string ContactNumber { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public int StaffStatusId { get; set; }

    [ForeignKey("UserId")]
    public UserEntity UserEntity { get; set; }

    [ForeignKey("StaffStatusId")]
    public StaffStatusEntity StaffStatusEntity { get; set; }

    public StaffEntity() { }
}
