using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models
{
    public class Note
    {
        public int NoteId { get; set; }
        public string ReceivedBy { get; set; }
        public string DeliveredTo { get; set; }
        public DateTime Created { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }
        public string NoteType { get; set; }
        public int Total { get; set; }

        public virtual ICollection<ProductNoteDetail> ProductNoteDetails { get; set; }
    }
}
