using PointOfSaleDataAccess;
using PointOfSaleSystem.Models.Product;

namespace PointOfSaleSystem.Services.Products
{
    public class ProductService : IProductRepository
    {
        private readonly POSDBContext _context = new();
        public List<ProductEntity> AllProduts()
        {
            return _context.Products.ToList();
        }

        public ProductEntity GetProductById(long id)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            return product;
        }
    }
}
