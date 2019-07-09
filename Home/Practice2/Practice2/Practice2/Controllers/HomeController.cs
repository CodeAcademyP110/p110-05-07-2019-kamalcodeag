using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice2.MyEF;

namespace Practice2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EFdb efdb;

        public HomeController(EFdb efdb2)
        {
            efdb = efdb2;
        }
        public IActionResult Index()
        {
            return View(efdb.Houses.Include(h => h.HousePhotos).OrderByDescending(h => h.Id).Take(4));
        }

        public IActionResult LoadMore()
        {
            //return Content("Loaded");
            return PartialView("_LoadMorePartial", efdb.Houses.Include(h => h.HousePhotos).OrderByDescending(h => h.Id).Take(4));

        }
    }
}
