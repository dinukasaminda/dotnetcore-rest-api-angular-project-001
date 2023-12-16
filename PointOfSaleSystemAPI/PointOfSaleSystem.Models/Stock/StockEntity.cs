using PointOfSaleSystem.Models.Product;

namespace PointOfSaleSystem.Models.Stock
{
    public class StockEntity
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }

        public double UnitCost { get; set; }

        public StockType Type { get; set; }

        public double UnitPrice { get; set; }

        public string BarcodePrefix { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ProductEntity Product { get; set; }
    }
}
