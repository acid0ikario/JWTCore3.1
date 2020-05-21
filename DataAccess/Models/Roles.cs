using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }

        [Key]
        public string Id { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
