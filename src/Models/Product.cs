using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Models
{
    public class Product
    {
        public int Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }    
        public string type { get; set; } = string.Empty;
        public int stock { get; set; }

        public List<User> Users { get; set; } = [];
    }
}