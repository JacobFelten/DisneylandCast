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
            return View();
        }
        
        [HttpPost]
        public ViewResult Messaging(Message message)
        {
            if (ModelState.IsValid)
            {
                User user;
                LookForUser(message.Sender);
                user = GetUser(message.Sender);
                user.SentMessages.Add(message);
                LookForUser(message.Receiver);
                user = GetUser(message.Receiver);
                user.ReceivedMessages.Add(message);
            }
            return View();
        }

        [HttpGet]
        public ViewResult ChooseUser()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ChooseUser(string username)
        {
            User user;
            LookForUser(username);
            user = GetUser(username);
            return View("MessageList", user);
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

        //Returns true if a user already exists in the Userbase. If not, this method
        //creates a new user with the username parameter and returns false.
        public bool LookForUser(string username)
        {
            User user = null;
            foreach (User u in Userbase.Users)
            {
                if (u.Name == username)
                    user = u;
            }
            if (user == null)
            {
                user = new User() { Name = username };
                Userbase.Users.Add(user);
                return false;
            }
            else
                return true;
        }

        //Finds and returns a user from Userbase by its name.
        public User GetUser(string username)
        {
            foreach (User u in Userbase.Users)
            {
                if (u.Name == username)
                    return u;
            }
            return null;
        }
    }
}
