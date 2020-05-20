using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class AuthenticateController : Controller
    {
        private readonly IUserservices _userservices;
        private readonly IAuthenticationService _authenticationService;
        public IActionResult Index()
        {
            return View();
        }
    }

    internal interface IUserservices
    {
    }
}