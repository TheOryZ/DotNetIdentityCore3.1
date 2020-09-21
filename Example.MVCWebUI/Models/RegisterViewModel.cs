using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.MVCWebUI.Models
{
    public class RegisterViewModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
