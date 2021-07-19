using ArtStore.DAL.Context;
using ArtStore.Entity;
using ArtStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Context
{
    public class StoreRepository
    {
        public void AddProduct(ProductDTO product)
        {

            using (var context = new StoreDbContext())
            {
                context.Add(product);
                context.SaveChanges();

            }
        }

        public List<ProductDTO> GetProducts()
        {
            using (var context = new StoreDbContext())
            {
                var productList = context.Products.ToList();
                return productList;
            }
            
        }
    }
}
