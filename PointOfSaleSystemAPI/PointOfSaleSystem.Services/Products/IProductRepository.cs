using PointOfSaleSystem.Models.Product;
using PointOfSaleSystem.Services.Models;

namespace PointOfSaleSystem.Services.Products
{
    public interface IProductRepository
    {
        List<ProductEntity> AllProduts(string? search);

        ProductEntity GetProductById(long id);

        ProductEntity CreateProduct(ProductEntity newProduct);
    }
}
