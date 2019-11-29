using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisneylandCast.Models;
using DisneylandCast.Repositories;
using System.Web;

namespace DisneylandCast.Controllers
{
    public class HomeController : Controller
    {
        IUserRepository repo;

        public HomeController(IUserRepository r)
        {
            repo = r;
        }

        public ViewResult Index()
        {
            string[] characters = { "Mickey", "Donald", "Goofy", "Minnie", "Pluto", "Daisy", "Pete" };
            ViewBag.CharOfDay = characters[(int)DateTime.Now.DayOfWeek];
            return View();
        }

        public ContentResult CharOfDay(string content)
        {
            return Content(content);
        }

        public IActionResult History()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public NoContentResult Unfinished()
        {
            return NoContent();
        }

        public ViewResult Locations()
        {
            repo.Locations.Sort((l1, l2) => l1.Name.CompareTo(l2.Name));
            return View("Locations", repo.Locations);
        }

        public ViewResult People()
        {
            repo.People.Sort((p1, p2) => p1.Name.CompareTo(p2.Name));
            return View("People", repo.People);
        }
    }
}
