using PointOfSaleSystem.Models.Products;
using PointOfSaleSystem.Services.Models;

namespace PointOfSaleSystem.Services.Products
{
    public class ProductMemoryService : IProductRepository
    {
        // list all products
        public List<Product> AllProduts()
        {
            var products = new List<Product>();
            products.Add(new Product
            {
                Id = 1,
                Name = "product1",
                BarcodePrefix = "1001",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "product2",
                BarcodePrefix = "1002",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });
            return products;
        }

        public List<Product> AllProduts(string? search)
        {
            throw new NotImplementedException();
        }

        public Product CreateProduct(CreateProductDto newProduct)
        {
            throw new NotImplementedException();
        }

        public Product CreateProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
