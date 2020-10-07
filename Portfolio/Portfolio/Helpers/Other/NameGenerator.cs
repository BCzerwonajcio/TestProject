using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Helpers.Other
{
    public class NameGenerator
    {
        public static Random Rnd = new Random();

        public string RandomLastNameGenerator()
        {
            var lst = new List<string>
            {
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Riddle",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor",
                "Anderson",
                "Thomas",
                "Jackson",
                "White",
                "Harris",
                "Martin",
                "Thompson",
                "Garcia",
                "Martinez"
            };
            var lasName = lst.OrderBy(xx => Rnd.Next()).First();
            return lasName;
        }

        public string RandomFirstnameGenerator()
        {
            var lst = new List<string>
            {
                "Tom",
                "Aiden",
                "Jackson",
                "Mason",
                "Liam",
                "Jacob",
                "Jayden",
                "Ethan",
                "Noah",
                "Lucas",
                "Logan",
                "Caleb",
                "Caden",
                "Jack",
                "Ryan",
                "Connor",
                "Sophia",
                "Emma",
                "Isabella",
                "Olivia",
                "Ava",
                "Lily",
                "Chloe",
                "Madison",
                "Emily",
                "Abigail",
                "Addison",
                "Mia",
                "Madelyn",
                "Ella",
                "Hailey"
            };

            var firstName = lst.OrderBy(xx => Rnd.Next()).First();
            return firstName;
        }
    }
}
