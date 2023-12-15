using Microsoft.EntityFrameworkCore;
using PointOfSaleSystemAPI.Models;

namespace PointOfSaleDataAccess
{
    public class POSDBContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=127.0.0.1,1433; Database=posProjectXV1; User Id=SA; Password=Password123; TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>().HasData(
                    new ProductEntity
                    {
                        Id = 1,
                        Name = "Product 1",
                        BarcodePrefix = "1001",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new ProductEntity
                    {
                        Id = 2,
                        Name = "Product 2",
                        BarcodePrefix = "1002",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new ProductEntity
                    {
                        Id = 3,
                        Name = "Product 3",
                        BarcodePrefix = "1003",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new ProductEntity
                    {
                        Id = 4,
                        Name = "Product 4",
                        BarcodePrefix = "1004",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    },
                    new ProductEntity
                    {
                        Id = 5,
                        Name = "Product 5",
                        BarcodePrefix = "1005",
                        CreatedDate = System.DateTime.Now,
                        UpdatedDate = System.DateTime.Now
                    }
            );
        }

    }
}
