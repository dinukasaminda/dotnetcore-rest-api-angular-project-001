using PointOfSaleSystem.Models.Product;

namespace PointOfSaleSystem.Services.Products
{
    public class ProductMemoryService : IProductRepository
    {
        // list all products
        public List<ProductEntity> AllProduts()
        {
            var products = new List<ProductEntity>();
            products.Add(new ProductEntity
            {
                Id = 1,
                Name = "product1",
                BarcodePrefix = "1001",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });
            products.Add(new ProductEntity
            {
                Id = 2,
                Name = "product2",
                BarcodePrefix = "1002",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });
            return products;
        }


        public ProductEntity GetProductById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
