using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Requests
{
    public class RequestLogin
    {
        [Required]
        public string User { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
