using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMarketAPI.Models;

namespace SMarketAPI.Data
{
    public class SMarketRepository : ISMarketRepository
    {
        private readonly SMarketContext _context;
        public SMarketRepository(SMarketContext context)
        {
            this._context = context;
        }


        public void Add<T>(T entity) where T : class  //no es asyncrono por que esto guarda en memoria primaria
        {
            _context.Add(entity);

        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.Include(p => p.Images).FirstAsync(p => p.ProductId == id);
            // if theres is not user asociated with the id this will return a product null
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var product = await _context.Products.Include(p=>p.Images).ToListAsync();
            return product;
        }

        public async Task<Product> PutProduct(int id,Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            if (await SaveAll())
                return product;
            return null;
            
        }

        public  async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;  // if is == 0 nothing has been saved and return false
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
