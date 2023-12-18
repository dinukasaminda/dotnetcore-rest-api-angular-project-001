using PointOfSaleSystem.Models.Products;
using PointOfSaleSystem.Services.Models;

namespace PointOfSaleSystem.Services.Products
{
    public interface IProductRepository
    {
        List<Product> AllProduts(string? search);

        Product GetProductById(long id);

        Product CreateProduct(Product newProduct);
    }
}
