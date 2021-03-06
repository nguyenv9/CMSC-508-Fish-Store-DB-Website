﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace FishStore.Controllers
{
    public class AccountController : Controller
    {
        // GET: Product/Info
        public ViewResult Login()
        {
            var product = new Account() { Name = "Clownfish" };
            return View(product);
        }

        public ViewResult Data()
        {
            var product = new Account() { Name = "Clownfish" };
            return View(product);
        }

        public ViewResult CreateAccount()
        {
            var product = new Account() { Name = "Clownfish" };
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
