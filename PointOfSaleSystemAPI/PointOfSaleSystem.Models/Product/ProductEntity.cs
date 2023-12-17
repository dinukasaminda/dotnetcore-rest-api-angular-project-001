using PointOfSaleSystem.Models.Stock;
using System.ComponentModel.DataAnnotations;

namespace PointOfSaleSystem.Models.Product
{
    public class ProductEntity
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        // barcode prefix
        [MaxLength(25)]
        public string BarcodePrefix { get; set; }

        // updated date
        public DateTime UpdatedDate { get; set; }


        // created date
        public DateTime CreatedDate { get; set; }

        // product stocks
        public List<StockEntity> Stocks { get; set; } = new List<StockEntity>();
    }
}
