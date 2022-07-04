using Application.Mappers;
using Application.Models;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<UserModel>> GetUserById([FromRoute] Guid id)
        {
            var user = await _userService.GetUserById(id);

            if (user == null)
                return NotFound();
            
            return Ok(UserMapper.Map(user));
        }

        [HttpGet]
        public async Task<ActionResult<UserModel>> GetUserList()
        {
            var userList = await _userService.GetUserList();
            
            return Ok(UserMapper.Map(userList));
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> InsertUser([FromBody] UserModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var newUser = await _userService.InsertUser(UserMapper.Map(user));

            return Ok(newUser);
        }

        [HttpPut]
        public async Task<ActionResult<UserModel>> UpdateUser([FromBody] UserModel user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var currentUser = await _userService.UpdateUser(UserMapper.Map(user));

            return Ok(currentUser);
        }
    }
}