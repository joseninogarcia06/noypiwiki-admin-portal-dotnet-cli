using Newtonsoft.Json;

namespace NoypiWikiAdminMicroservices.Model.Dto.Admin.StaffAuthentication;

public class StaffAuthenticationRequestDto
{
    [JsonProperty("emailAddress")]
    public string EmailAddress { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }
}
