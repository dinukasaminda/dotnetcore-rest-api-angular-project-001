using PointOfSaleSystemAPI.Models;

namespace PointOfSaleSystem.Services
{
    public interface IProductRepository
    {
        List<ProductEntity> AllProduts();

        ProductEntity GetProductById(Int64 id);
    }
}
