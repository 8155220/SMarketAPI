using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class Image
    {
        public long ImageId { get; set; }
        public string Url { get; set; }

        //Navigation properties
        public virtual Product Product { get; set; }
    }
}
