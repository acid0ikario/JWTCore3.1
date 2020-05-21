using BusinessServices.Interfaces;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Models;

namespace BusinessServices.Services
{
    public class UsersService : IUsersService
    {
        private readonly dbUsersContext _dbContext;
       
        public UsersService(dbUsersContext context)
        {
            _dbContext = context;
           
        }
        public Users AuthUser(string user, string password)
        {
            var AuthUser = _dbContext.Users.FirstOrDefault(x => x.UserId == user && x.Password == password);
            return AuthUser;
        }
    }
}
