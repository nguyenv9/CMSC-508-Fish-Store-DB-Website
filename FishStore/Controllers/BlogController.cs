using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishStore.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blogs()
        {
            return View();
        }
    }
}