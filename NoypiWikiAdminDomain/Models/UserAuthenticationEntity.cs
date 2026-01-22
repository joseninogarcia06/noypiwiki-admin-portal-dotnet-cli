using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

[Index(nameof(UserId), nameof(CreatedOn), nameof(ModifiedOn))]
public class UserAuthenticationEntity : BaseEntity
{
    public Guid UserId { get; set; }

    public string Password { get; set; }

    public string Salt { get; set; }

    public UserAuthenticationEntity() { }
}
