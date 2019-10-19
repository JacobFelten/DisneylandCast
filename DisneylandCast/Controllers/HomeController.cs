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
                GenerateMessageId(message);
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
        
        public ViewResult SendReply(string messageId, string sent)
        {
            Message message = GetMessage(int.Parse(messageId));
            message.Sent = bool.Parse(sent);
            return View("SendReply", HttpUtility.HtmlDecode(messageId));
        }
        
        [HttpPost]
        public ViewResult SendReply(string messageId, string replyText, bool overload)
        {
            Reply reply = new Reply { ReplyText = replyText };
            Message message = GetMessage(int.Parse(messageId));
            message.Replies.Add(reply);
            User user;
            if (message.Sent)
                user = GetUser(message.Sender);
            else
                user = GetUser(message.Receiver);
            return View("MessageList", user);
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

        //Returns true if a user already exists in the Repository. If not, this method
        //creates a new user with the username parameter and returns false.
        private bool LookForUser(string username)
        {
            User user = null;
            foreach (User u in Repository.Users)
            {
                if (u.Name == username)
                    user = u;
            }
            if (user == null)
            {
                user = new User() { Name = username };
                Repository.Users.Add(user);
                return false;
            }
            else
                return true;
        }

        //Finds and returns a user from Repository by its name.
        private User GetUser(string username)
        {
            foreach (User u in Repository.Users)
            {
                if (u.Name == username)
                    return u;
            }
            return null;
        }

        //Finds and returns a message from the users in the Repository by its id.
        private Message GetMessage(int id)
        {
            foreach (User u in Repository.Users)
            {
                foreach (Message m in u.AllMessages)
                {
                    if (m.MessageId == id)
                        return m;
                }
            }
            return null;
        }

        //Generates a unique id int for the messageID property of the
        //message parameter if it doesn't alread have one
        private void GenerateMessageId(Message message)
        {
            if (message.MessageId == 0)
            {
                int id = 0;
                foreach (User u in Repository.Users)
                {
                    foreach (Message m in u.AllMessages)
                    {
                        if (m.MessageId == id)
                            id++;
                    }
                }
                message.MessageId = id;
            }
        }
    }
}
