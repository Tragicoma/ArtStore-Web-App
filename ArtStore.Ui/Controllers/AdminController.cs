using ArtStore.Entity;
using ArtStore.Ui.Models;
using AutoMapper;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Web;



namespace ArtStore.Ui.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMapper _mapper;

        public AdminController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> Products { get; set; }
        public IEnumerable<PaintingAuthorDTO> Authors { get; set; }

        public IEnumerable<OrderDTO> Orders { get; set; }


        public ActionResult ProductEdit()
        {
            var pManager = new ProductManager();


            Products = pManager.GetShopFrontProducts();

            var listP = new List<ProductModel>();
            foreach (var item in Products)
            {
                var model = _mapper.Map<ProductModel>(item);
                listP.Add(model);
            }

            Authors = pManager.GetAuthors();

            var listA = new List<paintingAuthorModel>();
            foreach (var item in Authors)
            {
                var model = _mapper.Map<paintingAuthorModel>(item);
                listA.Add(model);
            }

            Orders = pManager.GetOrders();

            var listO = new List<OrderModel>();
            foreach (var item in Orders)
            {
                var model = _mapper.Map<OrderModel>(item);
                listO.Add(model);
            }


            dynamic dynList = new ExpandoObject();
            dynList.Products = listP;
            dynList.Authors = listA;
            dynList.Orders = listO;

            return View(dynList);
        }

        
        public ActionResult Delete(int id)
        {

            var pManager = new ProductManager();
            pManager.DeleteById(id);

            return RedirectToAction("ProductEdit", "Admin");
        }

        public ActionResult Edit(int id, string name, double price, int author, int category, string descrip)
        {

            var pManager = new ProductManager();

            var product = pManager.GetProductById(id);


            if(name!=null)
                product.Name = name;

            
            product.Price = price;
            product.Category = category;

            if(descrip!=null)
                product.Description = descrip;

            pManager.UpdateProduct(product);


            return RedirectToAction("ProductEdit", "Admin");
        }



        [HttpPost]
        public ActionResult AddProduct(string name, double price,int author, int category, string descrip)
        {

            var pManager = new ProductManager();

            var newp = new ProductDTO()
            {
                Name = name,
                Price = price,
                AuthorId = pManager.GetAuthorById(author).Id,
                Category = category,
                Description = descrip,
                Picture = "Default_pic.png"
            };

            pManager.AddProduct(newp);


            return RedirectToAction("ProductEdit", "Admin");
        }
        
    }
}
