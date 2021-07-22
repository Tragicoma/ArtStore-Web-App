using ArtStore.Entity;
using DAL.Context;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class ProductManager
    {

        public void AddProduct(ProductDTO product)
        {
            var repo = new StoreRepository();

                repo.AddProduct(product);

        }

        public ProductDTO GetProductById(int id)
        {
            var repo = new StoreRepository();
            var product = repo.GetProductById(id);

            return product;
        }

        public List<ProductDTO> GetShopFrontProducts()
        {
            var repo = new StoreRepository();
            var productList = repo.GetProducts();  

            return productList;
        }
    }
}
