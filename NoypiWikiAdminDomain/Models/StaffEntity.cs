using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

[Index(nameof(CreatedOn), nameof(ModifiedOn), nameof(UserId))]
public class StaffEntity : BaseEntity
{
    public Guid UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string ContactNumber { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public int StaffStatusId { get; set; }

    public StaffEntity() { }
}
