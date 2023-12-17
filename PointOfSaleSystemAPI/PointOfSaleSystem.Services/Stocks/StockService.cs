using Microsoft.EntityFrameworkCore;
using PointOfSaleDataAccess;
using PointOfSaleSystem.Models.Stock;
using PointOfSaleSystem.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Stocks
{
    public class StockService : IStockRepository
    {
        private readonly POSDBContext _context = new();

        public List<StockEntity> GetAllStocks()
        {
            return _context.Stocks.ToList();
        }


        public StockEntity GetStockById(long id)
        {
            var stock = _context.Stocks.Where(s => s.Id == id).FirstOrDefault();
            return stock;
        }

        public List<StockEntity> GetStocksByProductId(long productId)
        {
            var stocks = _context.Stocks.Where(s => s.ProductId == productId).ToList();
            return stocks;
        }

        public ProductVirtualPriceCalDto CalculateProductWAvgPrice(long productId, double profitMarginPercentage)
        {

            var result = new ProductVirtualPriceCalDto();
            var stocks = _context.Stocks.Where(s => s.ProductId == productId && s.Type==StockType.StockIn).ToList();


            var totalCost = 0.0;
            var itemCount = 0;


            foreach (var stock in stocks)
            {
                totalCost += stock.UnitCost * stock.Quantity;
                itemCount += stock.Quantity;
            }

            // round to 2 decimal places
            totalCost = Math.Round(totalCost, 2);


            var weightedAvgCost = totalCost / itemCount;
            weightedAvgCost = Math.Round(weightedAvgCost, 2);


            // if we sold all items by avg cost price we should get allCost



            var vertualUnitPrice = totalCost * (100 + profitMarginPercentage) / (100 * itemCount);
            vertualUnitPrice = Math.Round(vertualUnitPrice, 2);

            var totalProfit = vertualUnitPrice * itemCount - totalCost;
            totalProfit = Math.Round(totalProfit, 2);

            var unitProfit = totalProfit / itemCount;


            var profitPercentage = (totalProfit / totalCost) * 100;
            profitPercentage = Math.Round(profitPercentage, 2);

            result.ProductId = productId;
            result.TotalCost = totalCost;
            result.ItemCount = itemCount;
            result.WeightedAvgCost = weightedAvgCost;
            result.UnitPrice = vertualUnitPrice;

            result.ProfitMarginPercentage = profitPercentage;
            result.TotalProfit = totalProfit;
            result.UnitProfit = unitProfit;

            return result;

        }
    }
}
