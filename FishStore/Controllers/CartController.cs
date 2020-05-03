using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishStore.Controllers
{
    public class CartController : Controller
    {
        // GET: Product/Info
        public ViewResult Content()
        {
            var product = new Cart() { Name = "Clownfish" };
            return View(product);
        }

        public ViewResult Order ()
        {
            var product = new Cart() { Name = "Goldfish" };
            return View(product);
        }

        public ViewResult Checkout()
        {
            var product = new Cart() { Name = "Guppy" };
            return View(product);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //products
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

    }
}