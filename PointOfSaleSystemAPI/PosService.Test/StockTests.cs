using PointOfSaleSystem.Models.Invoice;
using PointOfSaleSystem.Models.Stock;
using PointOfSaleSystem.Services.Invoices;
using PointOfSaleSystem.Services.Stocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService.Test
{
    public class StockTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        // test for GetStocks
        [Fact]
        public void TestStockForProductId()
        {
            var productId = 1;
            var stockService = new StockService();
            var stocks = stockService.GetStocksByProductId(productId);

            var allCost = 0.0;
            var allItemCount = 0;

            var expactedAllCost = Math.Round(2800.0, 2);
            var expactedAllItemCount = 250;



            foreach (var stock in stocks)
            {
                allCost += stock.UnitCost * stock.Quantity;
                allItemCount += stock.Quantity;
            }

            // round to 2 decimal places
            allCost = Math.Round(allCost, 2);


            var weightedAvgCost = allCost / allItemCount;
            weightedAvgCost = Math.Round(weightedAvgCost, 2);



            Assert.Equal(expactedAllCost, allCost);
            Assert.Equal(expactedAllItemCount, allItemCount);

            // if we sold all items by avg cost price we should get allCost

            var totalIncome = weightedAvgCost * allItemCount;
            totalIncome = Math.Round(totalIncome, 2);

            // it should be equal to allCost but not exactly equal
            Assert.Equal(allCost, totalIncome);

            var vertualUnitPrice = totalIncome / allItemCount;
            vertualUnitPrice += 2;
            vertualUnitPrice = Math.Round(vertualUnitPrice, 2);

            var profit = vertualUnitPrice * allItemCount - allCost;
            profit = Math.Round(profit, 2);

            var profitPercentage = profit / allCost * 100;
            profitPercentage = Math.Round(profitPercentage, 2);

        }

        // Create invoice and stocks
        [Fact]
        public void createInvoiceAndAddStocks()
        {
           

            var stockService = new StockService();

            var stocks = new List<Stock> {
                new Stock
                {
                    ProductId=1,
                    Quantity=333,
                    UnitCost=10.0,
                    Type=StockType.StockIn,
                    CreatedDate=DateTime.Now,
                    ActionType=StockActionType.PurchaseByInvoice,
                },
                new Stock
                {
                    ProductId=2,
                    Quantity=444,
                    UnitCost=15.0,
                    Type=StockType.StockIn,
                    CreatedDate=DateTime.Now,
                     ActionType=StockActionType.PurchaseByInvoice,
                }
            };
            stocks= stockService.AddStock(stocks);


            var invoiceService = new InvoiceService();

            var barCodePrefix = "3005";
            var invoice = new Invoice
            {
                ComapnyName = "Test Company",
                InvoiceDate = DateTime.Now,
                Note = "Test Notes",
                TotalItemCost = 100.0,
                OtherCost = 10.0,
                StockBarcodePrefix = barCodePrefix,
                InvoiceStocks= stocks.Select(s=>new InvoiceStock
                {
                    StockId=s.Id,
                }).ToList()
            };
            var result = invoiceService.CreateInvoice(invoice);
            Assert.NotNull(result);


        }
    }
}
