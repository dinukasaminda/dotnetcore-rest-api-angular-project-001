namespace PointOfSaleSystemAPI.Models
{
    public class ProductEntity
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }

        // barcode prefix
        public string BarcodePrefix { get; set; }

        // updated date
        public DateTime UpdatedDate { get; set; }


        // created date
        public DateTime CreatedDate { get; set; }
    }
}
