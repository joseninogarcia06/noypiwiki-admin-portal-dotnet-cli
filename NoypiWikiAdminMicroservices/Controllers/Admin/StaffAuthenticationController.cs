using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoypiWikiAdminMicroservices.Constant;
using NoypiWikiAdminMicroservices.Interface.Admin;
using NoypiWikiAdminMicroservices.Model.Common;
using NoypiWikiAdminMicroservices.Model.Dto.Admin.StaffAuthentication;

namespace NoypiWikiAdminMicroservices.Controllers.Admin
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StaffAuthenticationController : ControllerBase
    {
        private readonly IUserAuthenticateService _userAuthenticateService;

        public StaffAuthenticationController(IUserAuthenticateService userAuthenticateService)
        {  
            _userAuthenticateService = userAuthenticateService;
        }

        [HttpPost("Login")]
        [ProducesResponseType(typeof(StaffAuthenticationResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> LoginAsync(StaffAuthenticationRequestDto req)
        {
            var response = new DefaultResponse(false, string.Empty, string.Empty, string.Empty, null, null);

            try
            {
                var service = await _userAuthenticateService.AuthenticateStaffAsync(req.EmailAddress, req.Password);

                if(service.Item2 is not null)
                {
                    response = new DefaultResponse(false, CommonConstant.SERVICE_ERROR_RET_CODE, CommonConstant.SERVICE_ERROR_RET_MSG, nameof(LoginAsync), service.Item2, null);
                    return Ok(response);
                }

                response = new DefaultResponse(true, CommonConstant.SUCCESS_RET_CODE, CommonConstant.SUCCESS_RET_MSG, nameof(LoginAsync), null, service.Item1);
                return Ok(response);
            }
            catch(Exception ex)
            {
                var error = new PrepareErrorResponse(ex, ex.Message, nameof(LoginAsync));
                return Ok(error.GetErrorResponse());
            }
        }
    }
}
