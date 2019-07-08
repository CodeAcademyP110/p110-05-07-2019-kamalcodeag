using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P110_CoreAjax.DAL;
using P110_CoreAjax.Models;
using Microsoft.EntityFrameworkCore;

namespace P110_CoreAjax.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //eager loading
            ViewBag.TotalCount = _context.Properties.Count();
            return View(_context.Properties.Include(p => p.PropertyPhotos).OrderByDescending(p => p.Id).Take(4));
        }

        public IActionResult LoadProperties(int skip)
        {
            #region return Json version
            //return Json(new
            //{
            //    data = _context.Properties.Include(p => p.PropertyPhotos).OrderByDescending(p => p.Id).Select(p => new {
            //        p.Id,
            //        p.Address,
            //        p.Price,
            //        p.Description,
            //        Photo = p.PropertyPhotos.Select(pp => pp.Image).FirstOrDefault()
            //    })
            //});
            #endregion

            var model = 
                _context.Properties.Include(p => p.PropertyPhotos).OrderByDescending(p => p.Id).Skip(skip).Take(4);

            return PartialView("_PropertiesPartial", model);
        }
    }
}