using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NoypiWikiAdminMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AdminUserController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            var adminUserResponse = new AdminUserLoginDto();
            adminUserResponse.LoginId = "7832";
            adminUserResponse.Password = _configuration["Data"];
            return Ok(adminUserResponse);
        }
    }
}
