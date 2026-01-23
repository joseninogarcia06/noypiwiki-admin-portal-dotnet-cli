using NoypiWikiAdminMicroservices.Model.Common;
using NoypiWikiAdminMicroservices.Model.Dto.Admin.StaffAuthentication;

namespace NoypiWikiAdminMicroservices.Interface.Admin;

public interface IUserAuthenticateService
{
    Task<(StaffAuthenticationResponseDto?, List<ExceptionsDto>?)> AuthenticateStaffAsync(string emailAddress, string password);
}
