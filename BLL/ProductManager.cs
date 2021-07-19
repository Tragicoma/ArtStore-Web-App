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

        public void FillFakeData()
        {


        }

        public List<ProductDTO> GetShopFrontProducts()
        {
            var repo = new StoreRepository();
            var productList = repo.GetProducts();  

            return productList;
        }
    }
}
