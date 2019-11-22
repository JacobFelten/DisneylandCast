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

        public List<User> Users { get { return users; } }
    }
}
