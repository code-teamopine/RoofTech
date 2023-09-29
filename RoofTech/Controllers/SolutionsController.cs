using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoofTech.Models;

namespace RoofTech.Controllers
{
    public class SolutionsController : Controller
    {
        public IActionResult accessories()
        {
            return View();
        }
        public IActionResult applications()
        {
            return View();
        }
        public IActionResult versatility()
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
