using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PointOfSaleSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {


        // Get all products
        [HttpGet] 
        public IActionResult GetProducts()
        {
            var products = new string[] { "product1", "product2" };
            return Ok(products);
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
