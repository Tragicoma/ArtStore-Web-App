using AutoMapper;
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

        public IActionResult Order()
        {
            return View();
        }
        public IActionResult ShopFront()
        {
            return View();
        }

    }
}
