using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    public partial class Users
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [ForeignKey("Rol")]
        public string RolId { get; set; }

        public virtual Roles Rol { get; set; }
    }
}
