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
        public IActionResult GetProductById(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var products = _productService.AllProduts();
            var product = products.Find(p => p.Id == int.Parse(id));
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
