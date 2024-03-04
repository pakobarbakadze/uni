using Microsoft.AspNetCore.Mvc;
using uni.Dtos;
using uni.Entities;
using uni.Services.UserServices;

namespace uni.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            return Ok(await _userService.GetUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return Ok(await _userService.GetUser(id));
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(AddUserDto addUserDto)
        {
            return Ok(await _userService.AddUser(addUserDto));
        }
    }
}