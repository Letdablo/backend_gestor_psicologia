using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGestor.Models;
using ApiGestor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiGestor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginControler : ControllerBase
    {
        private IUserService _userService;

        public LoginControler(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }



    }
}
