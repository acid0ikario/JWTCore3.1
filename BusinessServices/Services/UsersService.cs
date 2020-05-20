using BusinessServices.Interfaces;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;
using DataAccess.Models;

namespace BusinessServices.Services
{
    public class UsersService : IUsersService
    {
        private readonly UsersDbContext _dbContext;
       
        public UsersService(UsersDbContext context, IUsersService usersService)
        {
            _dbContext = context;
           
        }
        public Users AuthUser(string user, string password)
        {
            var AuthUser = _dbContext.Users.First(x => x.UserId == user && x.Password == password);
            if (user == null)
                throw new Exception("usuario o contraseña invalidos");

            return AuthUser;
        }
    }
}
