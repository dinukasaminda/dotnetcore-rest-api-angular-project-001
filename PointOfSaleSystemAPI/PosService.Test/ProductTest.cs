﻿using PointOfSaleSystem.Models.Product;
using PointOfSaleSystem.Services.Models;
using PointOfSaleSystem.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService.Test
{
    public class ProductTest
    {
        // Create product test
        [Fact]
        public void CreateProductTest()
        {
           
            var mappedproduct = new ProductEntity()
            {
                Name = "Test Product",
                BarcodePrefix = "2001",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            var productService = new ProductService();
            var product = productService.CreateProduct(mappedproduct);

            Assert.Equal(mappedproduct.Name, product.Name);
            Assert.Equal(mappedproduct.BarcodePrefix, product.BarcodePrefix);
            Assert.True(product.Id > 0);
        }   
      
    }
}