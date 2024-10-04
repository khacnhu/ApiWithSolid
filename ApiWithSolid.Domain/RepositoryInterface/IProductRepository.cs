using ApiWithSolid.Domain.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWithSolid.Domain.RepositoryInterface
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
        Task AddAsync(Product product);

        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);


    }
}
