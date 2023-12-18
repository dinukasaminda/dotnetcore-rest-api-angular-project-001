using PointOfSaleSystem.Models.Products;
using System.ComponentModel.DataAnnotations;

namespace PointOfSaleSystem.Models.Stock
{
    public class Stock
    {
        public long Id { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public double UnitCost { get; set; }
        public double UnitPrice { get; set; }

        public StockType Type { get; set; }
        public StockActionType ActionType { get; set; }


        public DateTime CreatedDate { get; set; }

        public Product Item { get; set; }
    }

    
}
