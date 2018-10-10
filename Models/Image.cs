using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Url { get; set; }
        public Boolean isMain { get; set;}
        public int ProductId { get; set;}
        //Navigation properties
        public virtual Product Product { get; set; }
    }
}
