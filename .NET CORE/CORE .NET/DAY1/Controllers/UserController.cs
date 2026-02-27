using DAY1.DTO;
using DAY1.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAY1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAuthService _service;
        public UserController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(UserDto request)
        {
            var user = await _service.RegisterUser(request);
            if (user == null)
            {
                return BadRequest("User Already Exists");
            }
            return Ok(user);
        }


        [HttpPost("login")]
        public async Task<IActionResult> LoginUser(LoginDto request)
        {
            var user = await _service.LoginUser(request);
            if (user is null)
            {
                return BadRequest("Email or Password is invalid");
            }

            return Ok(user);
        }

    }
}
