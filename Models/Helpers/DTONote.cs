using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Models.Helpers
{
    public class DTONote
    {
        public Note Note { get; set; }
        public ProductNoteDetail[] ProductNoteDetail { get; set; }
    }
}
