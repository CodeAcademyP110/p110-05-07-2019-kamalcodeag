using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice.Entity;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestingMyself testingMyself;
        public HomeController(TestingMyself testingMyself2)
        {
            testingMyself = testingMyself2;
        }
        public IActionResult Index()
        {
            return View(testingMyself.OurUsers);


            //First case with ViewBag
            //ViewBag.Text = "MyText";
            //return View();

            //Second case with ViewBag
            //ViewBag.Type = testingMyself.OurUsers;
            //return View();


        }
    }
}