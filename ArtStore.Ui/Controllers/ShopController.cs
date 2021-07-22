using ArtStore.Entity;
using ArtStore.Ui.Models;
using AutoMapper;
using BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Controllers
{
    public class ShopController : Controller
    {
        private readonly IMapper _mapper;

        public ShopController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> Products { get; set; }

        public IActionResult Order()
        {
            return View();
        }

        public IActionResult ProductDetails(string id)
        {
            var pManager = new ProductManager();
            var pDto = pManager.GetProductById(Convert.ToInt32(id));

            var pm = _mapper.Map<ProductModel>(pDto);


            return View(pm);
        }

        public IActionResult ShopFront()
        {


            var pManager = new ProductManager();

            //pManager.FillFakeData();

            Products = pManager.GetShopFrontProducts();

            var list = new List<ProductModel>();
            foreach (var item in Products)
            {
                var model = _mapper.Map<ProductModel>(item);
                list.Add(model);
            }

            return View(list);

        }

    }
}
