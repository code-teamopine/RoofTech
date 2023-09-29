using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoofTech.Models;

namespace RoofTech.Controllers
{
    public class ProductOfferingController : Controller
    {
        public IActionResult SteelBuildings()
        {
            return View();
        }
        public IActionResult HVLS_fans()
        {
            return View();
        }
        public IActionResult standing_seam_roof()
        {
            return View();
        }
        public IActionResult wind_driven_ventilators()
        {
            return View();
        }
        public IActionResult skylights()
        {
            return View();
        }
    }
}
