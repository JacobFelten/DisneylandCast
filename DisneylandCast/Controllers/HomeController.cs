using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisneylandCast.Models;
using System.Web;

namespace DisneylandCast.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string[] characters = { "Mickey", "Donald", "Goofy", "Minnie", "Pluto", "Daisy", "Pete" };
            ViewBag.CharOfDay = characters[(int)DateTime.Now.DayOfWeek];
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Locations()
        {
            Repository.Locations.Sort((l1, l2) => l1.Name.CompareTo(l2.Name));
            return View("Locations", Repository.Locations);
        }

        public ViewResult People()
        {
            Repository.People.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            return View("People", Repository.People);
        }
    }
}
