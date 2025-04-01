using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
=======
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using spotme_backend.Models.DTOS;
using spotme_backend.Services;
>>>>>>> af925110411b5a749b6f677393ef693acc620ca0

namespace spotme_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
<<<<<<< HEAD
        
=======
        private readonly UserServices _userServices;

        public UserController(UserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromBody] UserDto user)
        {
            bool success = await _userServices.CreateUser(user);

            if(success) return Ok(new {Success = true});

            return BadRequest(new {Success = false, Message = "User already Exists"});
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserDto user)
        {
            var success = await _userServices.Login(user);

            if(success != null) return Ok(new {Token = success});

            return Unauthorized(new {Message = "Username or Password is incorrect"}); 
        }

        [HttpGet("GetUserInfoByUsername/{username}")]
        public async Task<IActionResult> GetUserInfoByUsername(string username)
        {
            var user = await _userServices.GetUserInfoByUserName(username);

            if(user != null) return Ok(user);

            return BadRequest(new {Message = " User not found"});
        }
>>>>>>> af925110411b5a749b6f677393ef693acc620ca0
    }
}