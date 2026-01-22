using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NoypiWikiAdminMicroservices.Controllers.Admin
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StaffAuthenticationController : ControllerBase
    {
        public StaffAuthenticationController() { }

        [HttpPost]
        public async Task<IActionResult> LoginAsync()
        {
            return Ok("ok");
        }
    }
}
