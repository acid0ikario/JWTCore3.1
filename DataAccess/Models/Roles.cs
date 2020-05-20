using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class Roles
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
