using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Controllers
{
    public class ShopController : Controller
    {
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
