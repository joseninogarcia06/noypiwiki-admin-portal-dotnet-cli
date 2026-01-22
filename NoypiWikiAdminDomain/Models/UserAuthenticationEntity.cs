using System;
using System.ComponentModel.DataAnnotations.Schema;
using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

public class UserAuthenticationEntity : BaseEntity
{
    public Guid UserId { get; set; }

    public string Password { get; set; }

    public string Salt { get; set; }

    [ForeignKey("UserId")]
    public UserEntity UserEntity { get; set; }

    public UserAuthenticationEntity() { }
}
