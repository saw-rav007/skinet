using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _store;
        public ProductRepository(StoreContext store)
        {
            _store = store;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _store.Products.FindAsync(id);
        }


        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _store.Products.ToListAsync();
        }
    }
}