using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessServices.Interfaces
{
    public interface IAuthenticationService
    {
        string GenerateSecurityToken(Users usuario);
    }
}
