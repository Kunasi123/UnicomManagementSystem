using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment123.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }
        public string Role {  get; set; }
        public int ReferenceID { get; set; }
    }
}
