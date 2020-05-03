using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishStore.Controllers
{
    public class TankPlannerController : Controller
    {
        // GET: TankPlanner
        public ActionResult Planner()
        {
            return View();
        }
    }
}