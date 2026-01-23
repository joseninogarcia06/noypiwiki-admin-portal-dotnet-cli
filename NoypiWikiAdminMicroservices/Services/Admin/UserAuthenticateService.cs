using NoypiWikiAdminMicroservices.Interface.Admin;
using NoypiWikiAdminMicroservices.Model.Common;
using NoypiWikiAdminMicroservices.Model.Dto.Admin.StaffAuthentication;

namespace NoypiWikiAdminMicroservices.Services.Admin;

public class UserAuthenticateService : IUserAuthenticateService
{
    public UserAuthenticateService()
    {
        
    }
    
     public async Task<(StaffAuthenticationResponseDto?, List<ExceptionsDto>?)> AuthenticateStaffAsync(string emailAddress, string password)
    {
        throw new NotImplementedException();
    }
}
