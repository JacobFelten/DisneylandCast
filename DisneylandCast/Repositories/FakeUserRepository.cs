using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneylandCast.Models;

namespace DisneylandCast.Repositories
{
    public class FakeUserRepository : IUserRepository
    {
        private List<User> users = new List<User>();
        private List<Location> locations = new List<Location>();
        private List<Person> people = new List<Person>();

        public List<User> Users { get { return users; } }
        public List<Location> Locations { get { return locations; } }
        public List<Person> People { get { return people; } }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void AddReceivedMessage(User user, Message message)
        {
            user.ReceivedMessages.Add(message);
        }

        public void AddSentMessage(User user, Message message)
        {
            user.SentMessages.Add(message);
        }

        public void AddReply(Message message, Reply reply)
        {
            message.Replies.Add(reply);
        }
    }
}
