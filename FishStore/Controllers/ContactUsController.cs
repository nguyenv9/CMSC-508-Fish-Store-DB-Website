using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishStore.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: Product/Info
        public ViewResult Form ()
        {
            var product = new ContactUs() { Name = "Clownfish" };
            return View(product);
        }
    }
}
