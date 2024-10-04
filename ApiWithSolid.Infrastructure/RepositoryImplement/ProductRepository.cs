using ApiWithSolid.Domain.ProductEntity;
using ApiWithSolid.Domain.RepositoryInterface;
using ApiWithSolid.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWithSolid.Infrastructure.RepositoryImplement
{
    public class ProductRepository(AppDbContext context) : IProductRepository
    {
        public async Task AddAsync(Product product)
        {
            await context.Products.AddAsync(product);
            await context.SaveChangesAsync();
               
        }

        public async Task DeleteAsync(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product != null)
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            } 
                


        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await context.Products.AsNoTracking().ToListAsync();    
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await context.Products.FindAsync(id);
        }

        public async Task UpdateAsync(Product product)
        {
            context.Products.Update(product);
            await context.SaveChangesAsync();

        }
    }
}
