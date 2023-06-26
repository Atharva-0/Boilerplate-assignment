using CourseApp.Models.Users;
using CourseApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        readonly IAuthManager _authManager;
        public AccountController(IAuthManager authManager)
        {
            _authManager = authManager;
        }

        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Register([FromBody] ApiUserDto apiUserDto)
        {
            var errors = await _authManager.RegisterUser(apiUserDto);
            if (errors.Any())
            {
                foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest();
            }
            return Ok();

        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginDto logindto)
        {
            var authResponse = await _authManager.Login(logindto);
            if (authResponse == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(authResponse);
            }
        }
    }
}
