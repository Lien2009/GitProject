using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Implement;
using Services.Interfaces;

namespace ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllUsersAsync(int role, int method)
        {
            return Ok(await _userService.GetAllUsersAsync(role, method));
        }
    }
}
