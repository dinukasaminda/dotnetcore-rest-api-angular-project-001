using PointOfSaleDataAccess;
using PointOfSaleSystem.Models.Product;

namespace PointOfSaleSystem.Services.Products
{
    public class ProductService : IProductRepository
    {
        private readonly POSDBContext _context = new();
        public List<ProductEntity> AllProduts(string? search)
        {
            if (string.IsNullOrWhiteSpace(search) ){ 
               return _context.Products.ToList();
            }
            search = search.Trim();

            var productColl = _context.Products as IQueryable<ProductEntity>;

          
            productColl = productColl.Where(
                p => 
                    p.Name.Contains(search)  ||  p.BarcodePrefix.Contains(search)
                );
            return productColl.ToList();
        }

        public ProductEntity CreateProduct(ProductEntity newProduct)
        {
           
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        public ProductEntity GetProductById(long id)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            return product;
        }
    }
}
