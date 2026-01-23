using System;

namespace NoypiWikiAdminMicroservices.Model.Dto.Admin.StaffAuthentication;

public class StaffAuthenticationResponseDto
{
    public bool IsValidUser { get; set; }

    public string Token { get; set; }
}
