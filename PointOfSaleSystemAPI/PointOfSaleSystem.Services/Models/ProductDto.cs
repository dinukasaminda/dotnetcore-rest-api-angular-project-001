using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Models
{
    // Product Data Transfer Object
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string BarcodePrefix { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
