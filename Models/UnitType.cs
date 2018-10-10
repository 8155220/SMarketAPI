using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class UnitType
    {
        // Primary key
        public int UnitTypeId { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }

        // Navigation properties 
        //public virtual ICollection<Product> Products { get; set; }
    }
}
