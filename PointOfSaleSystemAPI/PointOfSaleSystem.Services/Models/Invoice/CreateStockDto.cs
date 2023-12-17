using PointOfSaleSystem.Models.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Models.Invoice
{
    public class CreateStockDto
    {
        public long ProductId { get; set; }

        public int Quantity { get; set; }

        public double UnitCost { get; set; }

        public StockType Type { get; set; }

        public double UnitPrice { get; set; }

        public string BarcodePrefix { get; set; }
    }
}
