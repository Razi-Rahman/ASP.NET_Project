using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}
