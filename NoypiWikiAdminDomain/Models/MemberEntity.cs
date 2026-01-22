using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models.Common;
namespace NoypiWikiAdminDomain.Models;

[Index(nameof(UserId), nameof(CreatedOn), nameof(ModifiedOn))]
public class MemberEntity : BaseEntity
{
    public Guid UserId { get; set; }

    public string Username { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string EmailAddress { get; set; }

    [ForeignKey("UserId")]
    public UserEntity User { get; set; }

    public MemberEntity() { } 
}
