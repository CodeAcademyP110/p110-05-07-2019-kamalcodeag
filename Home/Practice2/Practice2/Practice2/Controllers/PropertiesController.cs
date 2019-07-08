using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Practice2.Models;
using Practice2.MyEF;

namespace Practice2.Controllers
{
    public class PropertiesController : Controller
    {
        private readonly EFdb efdb;
        public PropertiesController(EFdb efdb2)
        {
            efdb = efdb2;
        }
        public IActionResult Details(int id)
        {
            HousePhoto housePhoto = efdb.HousePhotos.Where(hp => hp.Id == id).FirstOrDefault();
            return View(housePhoto);
        }
    }
}