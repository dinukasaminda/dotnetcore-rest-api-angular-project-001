using Microsoft.EntityFrameworkCore;
using PointOfSaleDataAccess;
using PointOfSaleSystem.Models.Stock;
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

        public StockEntity CalculatedVertualStockForAvgPrice(long productId)
        {
            var stocks = _context.Stocks.Where(s => s.ProductId == productId).ToList();
            var stockEntity = new StockEntity
                {
                    ProductId = productId,
                    Quantity = 0,
                    UnitCost = 0,
                    UnitPrice = 0,
                    Type = StockType.VirtualStock,
                    BarcodePrefix = "VIRTUAL",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                };
            double totalItems= 0;
            double totalCost = 0;
            double totalUnitPrice = 0;  
            stocks.ForEach(s =>
            {
                totalCost += s.UnitCost * s.Quantity;
                totalUnitPrice += s.UnitPrice * s.Quantity;
                totalItems += s.Quantity;

            });
            stockEntity.Quantity = (int)totalItems;
            stockEntity.UnitCost = totalCost / totalItems;
            stockEntity.UnitPrice = totalUnitPrice / totalItems;
                return stockEntity;
        }
    }
}
