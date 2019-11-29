using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneylandCast.Models;

namespace DisneylandCast.Repositories
{
    public interface IUserRepository
    {
        List<User> Users { get; }

        List<Person> People { get; }

        List<Location> Locations { get; }

        void AddUser(User user);

        void AddSentMessage(User user, Message message);

        void AddReceivedMessage(User user, Message message);

        void AddReply(Message message, Reply reply);
    }
}
