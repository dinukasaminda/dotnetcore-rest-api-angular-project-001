using PointOfSaleSystem.Models.Product;
using System.ComponentModel.DataAnnotations;

namespace PointOfSaleSystem.Models.Stock
{
    public class StockEntity
    {
        public long Id { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public double UnitCost { get; set; }

        public StockType Type { get; set; }

        public double UnitPrice { get; set; }

        [Required]
        [MaxLength(25)]
        public string BarcodePrefix { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ProductEntity Product { get; set; }
    }
}
