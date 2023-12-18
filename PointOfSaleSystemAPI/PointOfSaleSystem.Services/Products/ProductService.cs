using PointOfSaleDataAccess;
using PointOfSaleSystem.Models.Products;

namespace PointOfSaleSystem.Services.Products
{
    public class ProductService : IProductRepository
    {
        private readonly POSDBContext _context = new();
        public List<Product> AllProduts(string? search)
        {
            if (string.IsNullOrWhiteSpace(search) ){ 
               return _context.Products.ToList();
            }
            search = search.Trim();

            var productColl = _context.Products as IQueryable<Product>;

          
            productColl = productColl.Where(
                p => 
                    p.Name.Contains(search)  ||  p.BarcodePrefix.Contains(search)
                );
            return productColl.ToList();
        }

        public Product CreateProduct(Product newProduct)
        {
           
            _context.Products.Add(newProduct);
            _context.SaveChanges();
            return newProduct;
        }

        public Product GetProductById(long id)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            return product;
        }
    }
}
