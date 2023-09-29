using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoofTech.Models;

namespace RoofTech.Controllers
{
    public class RoofingController : Controller
    {
        public IActionResult technology()
        {
            return View();
        }
        public IActionResult product()
        {
            return View();
        }
        public IActionResult material()
        {
            return View();
        }
        public IActionResult installation()
        {
            return View();
        }
        public IActionResult design_and_drawing()
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
