using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Requests
{
    public class RequestLogin
    {
        public string User { get; set; }
        public string Password { get; set; }

    }
}
