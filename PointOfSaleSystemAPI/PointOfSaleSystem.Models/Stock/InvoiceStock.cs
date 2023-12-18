using PointOfSaleSystem.Models.Invoice;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PointOfSaleSystem.Models.Stock
{

    // InvoiceStock entity
    public class InvoiceStock
    {
        public long StockId { get; set; }

        [ForeignKey("Invoice")]
        public long InvoiceId { get; set; }

    }
}
