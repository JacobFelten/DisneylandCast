using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneylandCast.Models
{
    public static class Repository
    {
        private static List<Person> people = new List<Person>();
        private static List<Location> locations = new List<Location>();

        public static List<Person> People { get { return people; } }
        public static List<Location> Locations { get { return locations; } }

        static Repository()
        {
            AddTestData();
        }

        static void AddTestData()
        {
            locations.Add(new Location
            {
                Name = "Main Street U.S.A",
                Info = "Featuring shops, Great Moments with Mr. Lincoln," +
                       " and the world famous castle, this is the perfect" +
                       " place to begin and end your time at the park.",
                Link = "https://en.wikipedia.org/wiki/Main_Street,_U.S.A."
            });
            locations.Add(new Location
            {
                Name = "Adventureland",
                Info = "Enter the world of the jungle and become a part of" +
                       " great adventure movies like Tarzan and Indiana Jones.",
                Link = "https://en.wikipedia.org/wiki/Adventureland_(Disney)"
            });
            locations.Add(new Location
            {
                Name = "Frontierland",
                Info = "Become a part of the wild west on the Big Thunder" +
                       " Mountain Railroad rollercoaster. From there you can" +
                       " enter New Orleans Square and take a tour of the Haunted" +
                       " Mansion or catch a ride on the Pirates of the Caribbean.",
                Link = "https://en.wikipedia.org/wiki/Frontierland"
            });
            locations.Add(new Location
            {
                Name = "Toontown",
                Info = "Step into the world of Micky, Donald, and Goofy and" +
                       " become a part of the cartoon.",
                Link = "https://en.wikipedia.org/wiki/Mickey%27s_Toontown"
            });
            locations.Add(new Location
            {
                Name = "Star Wars: Galaxy's Edge",
                Info = "Come to one of the park’s newest locations and see what" +
                       " life was like a long time ago in a galaxy far far away.",
                Link = "https://en.wikipedia.org/wiki/Star_Wars:_Galaxy%27s_Edge"
            });
            locations.Add(new Location
            {
                Name = "Tomorrowland",
                Info = "See the world of the future and ride classic attractions" +
                       " such as Space Mountain, Autopia, and Finding Nemo Submarine Voyage.",
                Link = "https://en.wikipedia.org/wiki/Tomorrowland"
            });
            people.Add(new Person
            {
                Name = "Walt Disney",
                Bio = "No introduction needed.",
                Link = "https://en.wikipedia.org/wiki/Walt_Disney"
            });
            people.Add(new Person
            {
                Name = "Josh D'Amaro",
                Bio = "Current President of Disneyland Resort. He is in charge of over" +
                      " 31,000 cast members and has worked for Disneyland for 21 years.",
                Link = "https://publicaffairs.disneyland.com/leadership/josh-damaro/"
            });
            people.Add(new Person
            {
                Name = "Justin Rapp",
                Bio = "One of the two 2019-2020 park ambassadors. Disneyland has been" +
                      " electing new ambassadors for the park yearly since 1965.",
                Link = "https://publicaffairs.disneyland.com/community/ambassador-program/"
            });
            people.Add(new Person
            {
                Name = "Rafa Barron",
                Bio = "One of the two 2019-2020 park ambassadors. Disneyland has been" +
                      " electing new ambassadors for the park yearly since 1965.",
                Link = "https://publicaffairs.disneyland.com/community/ambassador-program/"
            });
        }
    }
}
