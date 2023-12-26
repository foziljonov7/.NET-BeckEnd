using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson18
{
    public class User
    {
        public User(string Fullname, int Age, string Location)
        {
            this.Fullname = Fullname;
            this.Age = Age;
            this.Location = Location;
        }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public void GetUsers()
        {
            Console.WriteLine($" FISH : {Fullname}, yoshi : {Age}, manzili : {Location}");
        }
    }
}
