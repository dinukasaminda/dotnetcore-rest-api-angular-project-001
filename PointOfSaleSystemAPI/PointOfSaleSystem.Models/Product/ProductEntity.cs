namespace PointOfSaleSystem.Models.Product
{
    public class ProductEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        // barcode prefix
        public string BarcodePrefix { get; set; }

        // updated date
        public DateTime UpdatedDate { get; set; }


        // created date
        public DateTime CreatedDate { get; set; }
    }
}
