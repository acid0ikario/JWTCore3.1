using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoWrapper.Extensions;
using AutoWrapper.Wrappers;
using BusinessServices.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApi.Models.Requests;
using WebApi.Models.Responses;

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

        public object ResponseToken { get; private set; }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate(RequestLogin user)
        {
            var userAthenticated = _userservices.AuthUser(user.User, user.Password);
            if (userAthenticated == null)
                return Unauthorized("Usuario o Contraseña Incorrectas");

            var token = _authenticationService.GenerateSecurityToken(userAthenticated);
            ResponseLogin res = new ResponseLogin();
            res.Token = token;
            res.Expire = DateTime.Now.AddDays(30);
            return Ok(res);
        }
    }

  
}