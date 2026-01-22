using System;
using System.ComponentModel.DataAnnotations;
using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

public class StaffStatusEntity : BaseEntity
{
    public int StaffStatusId { get; set; }

    public string Description { get; set; }

    public StaffStatusEntity() { } 
}
