using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoofTech.Models;

namespace RoofTech.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult ExpertiseAndCapabilities()
        {
            return View();
        }
        public IActionResult Engineering()
        {
            return View();
        }
        public IActionResult GroupCompanies()
        {
            return View();
        }
        public IActionResult GroupInroduction()
        {
            return View();
        }
        public IActionResult RooftechNetwork()
        {
            return View();
        }
        public IActionResult RooftechAchievements()
        {
            return View();
        }
        public IActionResult RooftechInroduction()
        {
            return View();
        }
        public IActionResult RooftechJourney()
        {
            return View();
        }
        public IActionResult RooftechManagement()
        {
            return View();
        }
        public IActionResult RooftechTeam()
        {
            return View();
        }
        public IActionResult RooftechVisionMission()
        {
            return View();
        }

        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult Achievements()
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
