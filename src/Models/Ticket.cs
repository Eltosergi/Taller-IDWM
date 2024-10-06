using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.src.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BuyId { get; set; }
        public Buy? Buy { get; set; }
    
    }
}