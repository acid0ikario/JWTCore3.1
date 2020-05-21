using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Requests;

namespace WebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AuthenticateController : Controller
    {
        private readonly IUsersService _userservices;
        private readonly IAuthenticationService _authenticationService;

        public AuthenticateController(IUsersService usersService, IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            _userservices = usersService;
        }
        [HttpPost("Authenticate")]
        public IActionResult Authenticate(RequestLogin user)
        {
            var userUthenticated = _userservices.AuthUser(user.User, user.Password);
            var token = _authenticationService.GenerateSecurityToken(userUthenticated);
            return Ok(token);
        }
    }

  
}