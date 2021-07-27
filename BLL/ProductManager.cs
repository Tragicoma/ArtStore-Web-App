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

        public void DeleteById(int id)
        {
            var repo = new StoreRepository();
            repo.DeleteById(id);
        }

        public ProductDTO GetProductById(int id)
        {
            var repo = new StoreRepository();
            var product = repo.GetProductById(id);

            return product;
        }

        public void UpdateProduct(ProductDTO product)
        {
            var repo = new StoreRepository();
            repo.UpdateProduct(product);
        }

        public PaintingAuthorDTO GetAuthorById(int id)
        {
            var repo = new StoreRepository();
            var authorDto = repo.GetAuthorById(id);

            return authorDto;
        }

        public List<ProductDTO> GetShopFrontProducts()
        {
            var repo = new StoreRepository();
            var productList = repo.GetProducts();  

            return productList;
        }

        public List<PaintingAuthorDTO> GetAuthors()
        {
            var repo = new StoreRepository();
            var productList = repo.GetAuthors();

            return productList;
        }


    }
}
