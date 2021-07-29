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
                context.Products.Add(product);
                context.SaveChanges();

            }
        }

        public void DeleteById(int id)
        {
            using(var context = new StoreDbContext())
            {
                ProductDTO product = context.Products.FirstOrDefault(x => x.Id == id);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public void UpdateProduct(ProductDTO product)
        {
            using (var context = new StoreDbContext())
            {
                context.Products.Update(product);
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

        public PaintingAuthorDTO GetAuthorById(int id)
        {
            using (var context = new StoreDbContext())
            {

                PaintingAuthorDTO authorDto = context.Authors.FirstOrDefault(x => x.Id == id);
                return authorDto;
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

        public List<PaintingAuthorDTO> GetAuthors()
        {
            using (var context = new StoreDbContext())
            {
                var AuthorList = context.Authors.ToList();
                return AuthorList;
            }

        }

        public List<OrderDTO> GetOrders()
        {
            using (var context = new StoreDbContext())
            {
                var OrderList = context.Orders.ToList();
                return OrderList;
            }
        }
    }
}
