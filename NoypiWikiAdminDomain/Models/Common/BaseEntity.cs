using System.ComponentModel.DataAnnotations;
namespace NoypiWikiAdminDomain.Models.Common;

public class BaseEntity
{
    [Key]
    public Guid ID { get; set; }

    public DateTimeOffset CreatedOn { get; set; }

    public string CreatedBy { get; set; } = string.Empty;

    public string CreatedByType { get; set; } = string.Empty;

    public DateTimeOffset ModifiedOn { get; set; }

    public string ModifiedBy { get; set; } = string.Empty;

    public string ModifiedByType { get; set; } = string.Empty;

    public bool IsActive { get; set; }
}
