using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using DisneylandCast.Models;

namespace DisneylandCast.Repositories
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Locations.Any())
            {
                Location l1 = new Location
                {
                    Name = "Main Street U.S.A",
                    Info = "Featuring shops, Great Moments with Mr. Lincoln," +
                       " and the world famous castle, this is the perfect" +
                       " place to begin and end your time at the park.",
                    Link = "https://en.wikipedia.org/wiki/Main_Street,_U.S.A."
                };
                context.Locations.Add(l1);

                Location l2 = new Location
                {
                    Name = "Adventureland",
                    Info = "Enter the world of the jungle and become a part of" +
                           " great adventure movies like Tarzan and Indiana Jones.",
                    Link = "https://en.wikipedia.org/wiki/Adventureland_(Disney)"
                };
                context.Locations.Add(l2);

                Location l3 = new Location
                {
                    Name = "Frontierland",
                    Info = "Become a part of the wild west on the Big Thunder" +
                           " Mountain Railroad rollercoaster. From there you can" +
                           " enter New Orleans Square and take a tour of the Haunted" +
                           " Mansion or catch a ride on the Pirates of the Caribbean.",
                    Link = "https://en.wikipedia.org/wiki/Frontierland"
                };
                context.Locations.Add(l3);

                Location l4 = new Location
                {
                    Name = "Toontown",
                    Info = "Step into the world of Micky, Donald, and Goofy and" +
                           " become a part of the cartoon.",
                    Link = "https://en.wikipedia.org/wiki/Mickey%27s_Toontown"
                };
                context.Locations.Add(l4);

                Location l5 = new Location
                {
                    Name = "Star Wars: Galaxy's Edge",
                    Info = "Come to one of the park’s newest locations and see what" +
                           " life was like a long time ago in a galaxy far far away.",
                    Link = "https://en.wikipedia.org/wiki/Star_Wars:_Galaxy%27s_Edge"
                };
                context.Locations.Add(l5);

                Location l6 = new Location
                {
                    Name = "Tomorrowland",
                    Info = "See the world of the future and ride classic attractions" +
                           " such as Space Mountain, Autopia, and Finding Nemo Submarine Voyage.",
                    Link = "https://en.wikipedia.org/wiki/Tomorrowland"
                };
                context.Locations.Add(l6);

                context.SaveChanges();

            }

            if (!context.People.Any())
            {
                Person p1 = new Person
                {
                    Name = "Walt Disney",
                    Bio = "No introduction needed.",
                    Link = "https://en.wikipedia.org/wiki/Walt_Disney"
                };
                context.People.Add(p1);

                Person p2 = new Person
                {
                    Name = "Josh D'Amaro",
                    Bio = "Current President of Disneyland Resort. He is in charge of over" +
                          " 31,000 cast members and has worked for Disneyland for 21 years.",
                    Link = "https://publicaffairs.disneyland.com/leadership/josh-damaro/"
                };
                context.People.Add(p2);

                Person p3 = new Person
                {
                    Name = "Justin Rapp",
                    Bio = "One of the two 2019-2020 park ambassadors. Disneyland has been" +
                          " electing new ambassadors for the park yearly since 1965.",
                    Link = "https://publicaffairs.disneyland.com/community/ambassador-program/"
                };
                context.People.Add(p3);

                Person p4 = new Person
                {
                    Name = "Rafa Barron",
                    Bio = "One of the two 2019-2020 park ambassadors. Disneyland has been" +
                          " electing new ambassadors for the park yearly since 1965.",
                    Link = "https://publicaffairs.disneyland.com/community/ambassador-program/"
                };
                context.People.Add(p4);

                context.SaveChanges();
            }
        }
    }
}
