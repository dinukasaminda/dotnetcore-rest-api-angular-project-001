using PointOfSaleSystem.Models.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PointOfSaleSystem.Models.Invoice
{
    public class InvoiceEntity
    {
        public long Id { get; set; }
        public DateTime InvoiceDate { get; set; }

        [MaxLength(200)]
        [Required]
        public string ComapnyName { get; set; }

        [MaxLength(200)]
        public string Note { get; set; }

        [Required]
        public double TotalItemCost { get; set; }


        public double OtherCost { get; set; }


        public List<StockEntity> StockItems { get; set; }
    }
}
