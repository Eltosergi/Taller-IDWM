using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Models
{
    public class User
    {
        public int Id { get; set;}
        public string Rut { get; set;} = string.Empty;
        public string Name { get; set;} = string.Empty;
        public string Email{ get; set;} = string.Empty;
        public string Genere { get; set;} = string.Empty;
        public DateOnly Birthdate { get; set;} = new DateOnly();
        public string Password { get; set;} = string.Empty;
        
        public List<Product> Products { get;} = [];

        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}