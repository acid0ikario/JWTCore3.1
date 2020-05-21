using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccess.Models;

namespace DataAccess.Context
{
    public partial class dbUsersContext : DbContext
    {
        public dbUsersContext()
        {
        }

        public dbUsersContext(DbContextOptions<dbUsersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

    }
}
