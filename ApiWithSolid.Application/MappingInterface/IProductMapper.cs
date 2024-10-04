using ApiWithSolid.Application.ProductDTOs;
using ApiWithSolid.Domain.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWithSolid.Application.MappingInterface
{
    public interface IProductMapper
    {
        ProductDto MapToDto(Product product);

        Product MapToEntity(CreateProductDto createProductDto);

        Product MapToEntity(UpdateProductDto updateProductDto);


    }
}
