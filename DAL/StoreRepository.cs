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

        public ProductDTO GetProductById(int id)
        {
                using (var context = new StoreDbContext())
                {
                    var products = new List<ProductDTO>();
                    ProductDTO product = context.Products.FirstOrDefault(x => x.Id == id);
                    return product;
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
