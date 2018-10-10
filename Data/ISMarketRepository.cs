using SMarketAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMarketAPI.Data
{
    public interface ISMarketRepository
    {
        void Add<T>(T entity) where T : class;  //where T is a type of class
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task<Product> PutProduct(int id, Product product);

    }
}
