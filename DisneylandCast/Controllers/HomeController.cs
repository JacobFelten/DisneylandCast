using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DisneylandCast.Models;

namespace DisneylandCast.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        //[HttpGet]
        public ViewResult Messaging()
        {
            return View();
        }

        /*
        [HttpPost]
        public ViewResult Messaging()
        {
            return View();
        }
        */

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Locations()
        {
            return View();
        }

        public ViewResult People()
        {
            return View();
        }
    }
}
