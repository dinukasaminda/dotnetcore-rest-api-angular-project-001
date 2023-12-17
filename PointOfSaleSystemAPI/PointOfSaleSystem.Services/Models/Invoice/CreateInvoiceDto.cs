using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Models.Invoice
{
    public class CreateInvoiceDto
    {
        public long Id { get; set; }
        public DateTime InvoiceDate { get; set; }

        public string ComapnyName { get; set; }
        public string Note { get; set; }

        public double TotalItemCost { get; set; }

        public double OtherCost { get; set; }

        public List<CreateStockDto> StockItems { get; set; }
    }
}
