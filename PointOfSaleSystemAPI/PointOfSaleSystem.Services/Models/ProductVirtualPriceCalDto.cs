using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Models
{
    public class ProductVirtualPriceCalDto
    {
        public long ProductId { get; set; }
        public double TotalCost { get; set; }
        public int ItemCount { get; set; }

        public double WeightedAvgCost { get; set; }

        public double UnitPrice { get; set; }

        public double ProfitMarginPercentage { get; set; }
        public double TotalProfit { get; set; }
        public double UnitProfit { get; set; }
    }
}
