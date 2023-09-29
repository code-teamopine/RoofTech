using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoofTech.Models;

namespace RoofTech.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Brochures()
        {
            return View();
        }
        public IActionResult eventexhibitionphotos()
        {
            return View();
        }
        public IActionResult lifeatRooftech()
        {
            return View();
        }
        public IActionResult Backgrounder()
        {
            return View();
        }
        public IActionResult PrintAdvertisement()
        {
            return View();
        }
        public IActionResult RooftechBackgrounder()
        {
            return View();
        }
        public IActionResult Testimonials()
        {
            return View();
        }
        public IActionResult Videos()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
