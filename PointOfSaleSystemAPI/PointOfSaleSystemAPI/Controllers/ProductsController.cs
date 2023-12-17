using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PointOfSaleSystem.Models.Product;
using PointOfSaleSystem.Services.Models;
using PointOfSaleSystem.Services.Products;

namespace PointOfSaleSystemAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductRepository _productService;
        private readonly IMapper _mapper;


        
        public ProductsController(IProductRepository productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        // Get all products
        [HttpGet] 
        public ActionResult<ICollection<ProductDto>> GetProducts([FromQuery(Name = "search")] string? search)
        {

            var products =  _productService.AllProduts(search);

            var mappedProducts = _mapper.Map<ICollection<ProductDto>>(products);

            return Ok(mappedProducts);
        }

        // Get a product by id
        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProductById(long id)
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
            var mappedProduct = _mapper.Map<ProductDto>(product);

            return Ok(mappedProduct);
        }   

        // Create a product
        [HttpPost]
        public ActionResult<ProductDto> CreateProduct(CreateProductDto product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            var productEntity = _mapper.Map<ProductEntity>(product);
            var newProduct = _productService.CreateProduct(productEntity);

            var mappedProduct = _mapper.Map<ProductDto>(newProduct);


            return Ok(mappedProduct);
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
