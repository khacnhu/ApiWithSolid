using ApiWithSolid.Application.MappingInterface;
using ApiWithSolid.Application.ProductDTOs;
using ApiWithSolid.Domain.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWithSolid.Application.MappingImplementation
{
    public class ProductMapper : IProductMapper
    {
        public ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock
            };
        }

        public Product MapToEntity(CreateProductDto createProductDto)
        {
            return new Product
            {
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Stock = createProductDto.Stock
            };

        }

        public Product MapToEntity(UpdateProductDto updateProductDto)
        {
            return new Product
            {
                Id = updateProductDto.Id,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Stock = updateProductDto.Stock
            };
        }
    }
}
