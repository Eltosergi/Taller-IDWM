using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Models
{
    public class Buy
    {
        public int Id { get; set; }
        public List<Product> Products { get;} = [];
        public int UserId { get; set; }
        public User? User { get; set; }
        public string dirrecion { get; set; } = string.Empty;
        public int total { get; set; }

    }
}