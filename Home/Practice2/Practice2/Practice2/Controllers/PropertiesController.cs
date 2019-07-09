using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            House house = efdb.Houses.Include(h => h.HousePhotos).FirstOrDefault(h => h.Id == id);

            if(house == null)
            {
                return NotFound();
            }

            return View(house);
        }
    }
}