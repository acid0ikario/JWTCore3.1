using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        [HttpGet]
        public IActionResult Authenticate(string user, string password)
        {
            var userUthenticated = _userservices.AuthUser(user, password);
            var token = _authenticationService.GenerateSecurityToken(userUthenticated);
            return Ok(token);
        }
    }

  
}