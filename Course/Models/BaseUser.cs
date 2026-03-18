using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Course.Models
{
    public class BaseUser
    {
        public string Username { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Adress { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
