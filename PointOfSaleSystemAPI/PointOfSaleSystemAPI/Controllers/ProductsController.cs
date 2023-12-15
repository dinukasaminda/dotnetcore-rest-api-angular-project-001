using Microsoft.AspNetCore.Mvc;
using PointOfSaleSystem.Services;
using PointOfSaleSystemAPI.Services;

namespace PointOfSaleSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductRepository _productService;

        public ProductsController(IProductRepository productService)
        {
            _productService = productService;
        }

        // Get all products
        [HttpGet] 
        public IActionResult GetProducts()
        {
            var products =  _productService.AllProduts();
            return Ok(products);
        }

        // Get a product by id
        [HttpGet("{id}")]
        public IActionResult GetProductById(Int64 id)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }   

        // Create a product
        [HttpPost]
        public IActionResult CreateProduct()
        {
            return Ok();
        }

        // Update a product
        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return Ok();
        }

        // Delete a product

        [HttpDelete]
        public IActionResult DeleteProduct(  string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            return Ok();
        }



      
    }

}
