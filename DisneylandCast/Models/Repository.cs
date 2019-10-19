using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneylandCast.Models
{
    public static class Repository
    {
        private static List<User> users = new List<User>();
        private static List<Person> people = new List<Person>();
        private static List<Location> locations = new List<Location>();

        public static List<User> Users { get { return users; } }
        public static List<Person> People { get { return people; } }
        public static List<Location> Locations { get { return locations; } }
    }
}
