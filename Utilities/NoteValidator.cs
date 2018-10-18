using SMarketAPI.Models;
using SMarketAPI.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Utilities
{
    public class NoteValidator
    {
        public string NOTETYPE_ENTRY = "entry";
        public string NOTETYPE_REMOVAL = "removal";

        public static bool enoughStock(DTONote dtoNote, SMarketContext _context)
        {
             string NOTETYPE_ENTRY = "entry";
             string NOTETYPE_REMOVAL = "removal";
            Note note = dtoNote.Note;
            ProductNoteDetail[] productDetail = dtoNote.ProductNoteDetail;

            if(note.NoteType.Equals(NOTETYPE_ENTRY))
            {
                foreach (ProductNoteDetail e in productDetail)
                {
                    Product product = _context.Products.Find(e.ProductId);
                    //if (e.Quantity > product.Quantity)
                    product.Quantity = product.Quantity + e.Quantity;
                }
            }
            else
            {
                foreach (ProductNoteDetail e in productDetail)
                {
                    Product product = _context.Products.Find(e.ProductId);
                    //if (e.Quantity > product.Quantity)
                    product.Quantity = product.Quantity - e.Quantity;
                }
            }
            


            productDetail.ToList().ForEach(
                e =>
                {
                    Product product = _context.Products.Find(e.ProductId);

                    if (e.Quantity > product.Quantity)
                    {
                        product.Quantity = product.Quantity - e.Quantity;

                    }
                    //else 
                }
                );
            return true;

        }
    }
}
