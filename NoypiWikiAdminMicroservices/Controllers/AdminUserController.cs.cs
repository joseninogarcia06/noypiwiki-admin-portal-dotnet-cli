using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NoypiWikiAdminMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            var adminUserResponse = new AdminUserLoginDto();
            adminUserResponse.LoginId = "7832";
            adminUserResponse.Password = "123";
            return Ok(adminUserResponse);
        }
    }
}
