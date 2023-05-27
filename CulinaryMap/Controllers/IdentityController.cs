using CulinaryMap.Models;
using CulinaryMap.Models.Request;
using CulinaryMap.Models.Response;
using CulinaryMap.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CulinaryMap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly IIdentityService identityService;

        public IdentityController(IIdentityService identityService)
        {
            this.identityService = identityService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            try 
            {
                var response = await identityService.Register(registerModel);
                return Ok(response);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var response = await identityService.Login(loginModel);
                return Ok(response);
            }
            catch
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
