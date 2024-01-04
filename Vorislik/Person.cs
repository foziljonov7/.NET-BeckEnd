using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorislik
{
    public class Person
    {
        private string name { get; set; } //Nabijon
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}
