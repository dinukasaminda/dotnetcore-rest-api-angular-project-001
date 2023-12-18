using Microsoft.EntityFrameworkCore;
using PointOfSaleSystem.Models.Invoice;
using PointOfSaleSystem.Models.Products;
using PointOfSaleSystem.Models.Stock;

namespace PointOfSaleDataAccess
{
    public class POSDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceStock>  InvoiceStocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=127.0.0.1,1433; Database=posProjectXV1; User Id=SA; Password=Password123; TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var productModel = modelBuilder.Entity<Product>();
            productModel.HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Product 1",
                        BarcodePrefix = "1001",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Product 2",
                        BarcodePrefix = "1002",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Product 3",
                        BarcodePrefix = "1003",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Product 4",
                        BarcodePrefix = "1004",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Product 5",
                        BarcodePrefix = "1005",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    }
            );

            var stockModel = modelBuilder.Entity<Stock>();
            stockModel.HasData(
                new Stock
                {
                    Id = 1,
                    ProductId = 1,
                    Quantity = 10,
                    UnitCost = 123.34,
                    UnitPrice = 125.34,
                    Type = StockType.StockIn,
                    CreatedDate = System.DateTime.Now,
                },

                new Stock
                {
                    Id = 2,
                    ProductId = 2,
                    Quantity = 10,
                    UnitCost = 12.09,
                    UnitPrice = 14.09,
                    Type = StockType.StockIn,
                    CreatedDate = System.DateTime.Now,
                },
                new Stock
                {
                    Id = 3,
                    ProductId = 3,
                    Quantity = 100,
                    UnitCost = 2.00,
                    UnitPrice = 4.00,
                    Type = StockType.StockIn,
                    CreatedDate = System.DateTime.Now,
                },
                new Stock
                {
                    Id = 4,
                    ProductId = 4,
                    Quantity = 1000,
                    UnitCost = 500.00,
                    UnitPrice = 600.00,
                    Type = StockType.StockIn,
                    CreatedDate = System.DateTime.Now,
                },
                new Stock
                {
                    Id = 5,
                    ProductId = 5,
                    Quantity = 5,
                    UnitCost = 124.00,
                    UnitPrice = 126.00,
                    Type = StockType.StockIn,
                    CreatedDate = System.DateTime.Now,
                },
                 new Stock
                 {
                     Id = 6,
                     ProductId = 1,
                     Quantity = 35,
                     UnitCost = 126.34,
                     UnitPrice = 128.34,
                     Type = StockType.StockIn,
                     CreatedDate = System.DateTime.Now,
                 }
            );

            modelBuilder.Entity<Invoice>().HasIndex(x => x.StockBarcodePrefix).IsUnique();

            var invoiceStocks = modelBuilder.Entity<InvoiceStock>();
            invoiceStocks.HasKey(x => new { x.InvoiceId, x.StockId });

        }
    }
}
