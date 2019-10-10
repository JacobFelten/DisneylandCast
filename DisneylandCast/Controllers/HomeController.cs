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

        [HttpGet]
        public ViewResult Messaging()
        {
            if (Userbase.Users.Count == 0)
                Userbase.Users.Add(new User() { Name = "Me" });
            return View();
        }
        
        [HttpPost]
        public ViewResult Messaging(Message message)
        {
            if (ModelState.IsValid)
            {
                foreach (User u in Userbase.Users)
                {
                    if (message.Sender == u.Name)
                    {
                        u.SentMessages.Add(message);
                    }
                    if (message.Receiver == u.Name)
                    {
                        u.ReceivedMessages.Add(message);
                    }
                }
            }
            return View();
        }

        public ViewResult MessageList()
        {
            return View("MessageList", Userbase.Users[0]);
        }

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
