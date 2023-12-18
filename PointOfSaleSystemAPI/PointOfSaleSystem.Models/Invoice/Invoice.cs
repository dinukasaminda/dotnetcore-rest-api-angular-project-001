using PointOfSaleSystem.Models.Stock;
using System.ComponentModel.DataAnnotations;


namespace PointOfSaleSystem.Models.Invoice
{

    // Invoice entity
    public class Invoice
    {
        public long Id { get; set; }
        public DateTime InvoiceDate { get; set; }

        [MaxLength(200)]
        [Required]
        public string ComapnyName { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        [Required]
        [MaxLength(100)]
        public string StockBarcodePrefix { get; set; }

        [Required]
        public double TotalItemCost { get; set; }


        public double OtherCost { get; set; }

       public List<InvoiceStock> InvoiceStocks { get; set; }
    }
}
