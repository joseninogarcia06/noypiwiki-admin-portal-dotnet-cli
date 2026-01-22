using NoypiWikiAdminDomain.Models.Common;

namespace NoypiWikiAdminDomain.Models;

public class Staff : BaseEntity
{
    public Guid UserId { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string MiddleName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string ContactNumber { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public string EmploymentStatus { get; set; } = string.Empty;

    public Staff() { }
}
