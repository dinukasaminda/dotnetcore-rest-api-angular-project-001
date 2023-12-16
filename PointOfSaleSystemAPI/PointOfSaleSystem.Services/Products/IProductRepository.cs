using PointOfSaleSystem.Models.Product;

namespace PointOfSaleSystem.Services.Products
{
    public interface IProductRepository
    {
        List<ProductEntity> AllProduts();

        ProductEntity GetProductById(long id);
    }
}
