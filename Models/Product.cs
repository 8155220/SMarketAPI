using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string SellPrice { get; set; }
        public string BuyPrice { get; set; }
        public string ExpirationDate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } //falta ver

        // Foreign key
        //public int ImageId { get; set; }
        //public int TypeId { get; set; }
        public int UnitTypeId { get; set; }
        public int ProductTypeId { get; set; }
        // Navigation property

        public virtual ICollection<Image> Images { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual  UnitType UnitType { get; set; }
    }
}
