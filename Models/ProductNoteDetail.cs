using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class ProductNoteDetail
    {
        public int ProductNoteDetailId { get; set; }

        public int Quantity { get; set; }
        public int NoteId { get; set; }
        public int ProductId { get; set; }
        public Decimal Amount { get; set; }

        public virtual Product Product { get; set; }
        public virtual Note Note { get; set; }
    }
}
