﻿using PointOfSaleDataAccess;
using PointOfSaleSystemAPI.Models;
using System.Linq;

namespace PointOfSaleSystem.Services
{
    public class ProductService : IProductRepository
    {
        private readonly POSDBContext _context = new();
        public List<ProductEntity> AllProduts()
        {
            return _context.Products.ToList();
        }

        public ProductEntity GetProductById(Int64 id)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            return product;
        }
    }
}
