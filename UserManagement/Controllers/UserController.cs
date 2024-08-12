using Microsoft.AspNetCore.Mvc;
using UserManagement.Dtos;
using UserManagement.Services;

namespace UserManagement.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromBody] User user)
        {
            if (user == null)
                return BadRequest("User cannot be null");
            await _userService.AddAsync(user);
            return Ok("User added successfully");
        }

        [HttpDelete]
        [Route("/delete/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var userToRemove = await _userService.DeleteAsync(id);
            if (userToRemove == null)
                return Ok("User deleted successfully");
            else
                return NotFound("User not found");
        }
        [HttpPut]
        [Route("/update")]
        public async Task<IActionResult> UpdateAsync([FromBody] User user)
        {

            var userToUpdate = await _userService.UpdateAsync(user);
            if (userToUpdate == null)
                return Ok("User updated successfully");
            else
                return NotFound("User not found");

        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllAsync()
        {
            var users = await _userService.GetAllAsync(); // Assuming GetAllAsync is a method in IUserService
            return Ok(users);
        }

        [HttpGet("getById/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {

            var users = await _userService.GetByIdAsync(id);
            return Ok(users);

        }
    }
}
