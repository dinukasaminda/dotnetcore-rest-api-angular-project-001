using PointOfSaleSystem.Models.Stock;
using System.ComponentModel.DataAnnotations;

namespace PointOfSaleSystem.Models.Products
{

    // Product entity
    public class Product
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
        public List<Stock.Stock> Stocks { get; set; } = new List<Stock.Stock>();
    }
}
