using PointOfSaleSystem.Models.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Stocks
{
    public interface IStockRepository
    {

        // get stock by id
        public StockEntity GetStockById(long id);

        // get all stocks by product id
        public List<StockEntity> GetStocksByProductId(long productId);

        // get all stocks 
        public List<StockEntity> GetAllStocks();

        // calculate average price stock entity
        public StockEntity CalculatedVertualStockForAvgPrice(long productId);
       

        // add stock

        // update stock

        // delete stock


    }
}
