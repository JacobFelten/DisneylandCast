using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneylandCast.Models;
using Microsoft.EntityFrameworkCore;

namespace DisneylandCast.Repositories
{
    public class UserRepository : IUserRepository
    {
        //"Data Source=SQL5047.site4now.net;Initial Catalog=DB_A4F6FA_DisneylandCast;User Id=DB_A4F6FA_DisneylandCast_admin;Password=YOUR_DB_PASSWORD;"

        private AppDbContext context;

        public UserRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public List<User> Users
        {
            get
            {
                return context.Users
                    .Include(user => user.SentMessages)
                        .ThenInclude(message => message.Replies)
                    .Include(user => user.ReceivedMessages)
                        .ThenInclude(message => message.Replies)
                    .ToList();
            }
        }

        public List<Location> Locations
        {
            get
            {
                return context.Locations.ToList();
            }
        }

        public List<Person> People
        {
            get
            {
                return context.People.ToList();
            }
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void AddSentMessage(User user, Message message)
        {
            user.SentMessages.Add(message);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void AddReceivedMessage(User user, Message message)
        {
            user.ReceivedMessages.Add(message);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void AddReply(Message message, Reply reply)
        {
            message.Replies.Add(reply);
            context.Messages.Update(message);
            context.SaveChanges();
        }
    }
}
