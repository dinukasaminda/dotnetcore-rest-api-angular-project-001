﻿using PointOfSaleSystem.Models.Stock;
using PointOfSaleSystem.Services.Models;
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
        public Stock GetStockById(long id);

        // get all stocks by product id
        public List<Stock> GetStocksByProductId(long productId);

        // get all stocks 
        public List<Stock> GetAllStocks();

        // calculate average price stock entity
        public ProductVirtualPriceCalDto CalculateProductWAvgPrice(long productId,double profitMarginPercentage);


        // add stocks
        public List<Stock> AddStock(List<Stock> stockEntitis);

        // update stock

        // delete stock


    }
}
