using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneylandCast.Models
{
    public static class Userbase
    {
        private static List<User> users = new List<User>();

        public static List<User> Users { get { return users; } }
    }
}
