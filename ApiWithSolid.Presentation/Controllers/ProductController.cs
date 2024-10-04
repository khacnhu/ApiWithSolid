using ApiWithSolid.Application.ProductDTOs;
using ApiWithSolid.Application.UsecaseInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace ApiWithSolid.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService): ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await productService.GetAllProductsAsync();
            return Ok(products);
        }


        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await productService.GetProductByIdAsync(productId);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            await productService.AddProductAsync(createProductDto);
            return CreatedAtAction(nameof(GetById), new { id = createProductDto.Name }, createProductDto);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] UpdateProductDto updateProductDto)
        {
            if (id != updateProductDto.Id)
            {
                return BadRequest();
            }
            await productService.UpdateProductAsync(updateProductDto);
            return Ok(updateProductDto);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await productService.DeleteProductAsync(id);
            return Ok("Delete Successfully"); 
        }

    }
}
