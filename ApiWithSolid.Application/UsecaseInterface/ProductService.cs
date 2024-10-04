using ApiWithSolid.Application.MappingInterface;
using ApiWithSolid.Application.ProductDTOs;
using ApiWithSolid.Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWithSolid.Application.UsecaseInterface
{
    public class ProductService(IProductRepository productRepository, IProductMapper productMapper) : IProductService
    {
        public async Task AddProductAsync(CreateProductDto createProductDto)
        {
            var product = productMapper.MapToEntity(createProductDto);
            await productRepository.AddAsync(product);
            
        }

        public async Task DeleteProductAsync(int id)
        {
            await productRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
            var products = await productRepository.GetAllAsync();
            return products.Select(product => productMapper.MapToDto(product)).ToList();
        }

        public async Task<ProductDto?> GetProductByIdAsync(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            return product == null ? null : productMapper.MapToDto(product);

        }

        public async Task UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            var product = productMapper.MapToEntity(updateProductDto);
            await productRepository.UpdateAsync(product);

        }
    }
}
