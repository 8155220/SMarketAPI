using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class ProductType
    {
        // Primary key
        public int ProductTypeId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        //public virtual Product Product { get; set; }
        //public virtual ICollection<Product> Products{ get; set; }
    }
}
