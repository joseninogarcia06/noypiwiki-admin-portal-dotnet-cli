using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoypiWikiAdminMicroservices.Model.Dto.Admin.StaffAuthentication;

namespace NoypiWikiAdminMicroservices.Controllers.Admin
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StaffAuthenticationController : ControllerBase
    {
        public StaffAuthenticationController() { }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(StaffAuthenticationRequestDto req)
        {
            try
            {
                return Ok("ok");
            }
            catch(Exception ex)
            {
                return Ok("ok");
            }
        }
    }
}
