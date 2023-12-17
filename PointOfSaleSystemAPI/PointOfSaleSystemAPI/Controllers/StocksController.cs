using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PointOfSaleSystem.Services.Models;
using PointOfSaleSystem.Services.Stocks;

namespace PointOfSaleSystemAPI.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class StocksController : ControllerBase
    {

        private readonly IStockRepository _stockService;
        public StocksController(IStockRepository stockService)
        {
                _stockService = stockService;
        }

      
        [HttpGet]
        public IActionResult GetAllStocks([FromQuery(Name = "productId")] string productId= null)
        {
            if (productId != null)
            {
                var stocks = _stockService.GetStocksByProductId(int.Parse(productId));
                return Ok(stocks);
            }
            else
            {
                var stocks = _stockService.GetAllStocks();
                return Ok(stocks);
            }
        }

        /// get stock by id
        [HttpGet("stock/{stockId}")]
        public IActionResult GetStockById(int stockId)
        {
            if (stockId <= 0)
            {
                return BadRequest();
            }
            var stock = _stockService.GetStockById(stockId);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        /// Calculate profit margin per product using weighted average cost
        [HttpGet("stock/avg")]
        public ActionResult<ProductVirtualPriceCalDto> CalProductAvgPrice([FromQuery] int productId, [FromQuery]  double profitPercentage)
        {
            if (productId <= 0 || profitPercentage<0)
            {
                return BadRequest();
            }
            var stock = _stockService.CalculateProductWAvgPrice(productId, profitPercentage);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }


    }
}
