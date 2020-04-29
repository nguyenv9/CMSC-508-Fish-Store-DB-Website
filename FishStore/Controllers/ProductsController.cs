using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishStore.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Product/Info
        public IActionResult Info()
        {
            var product = new Product() { Name = "Clownfish" };
            return View(product);
        }
    }
}