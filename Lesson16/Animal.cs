using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lesson16
{
    public class Animal
    {
        public string Nomi { get; set; }
        public string Turi { get; set; }

        public void GetAnimal()
            => Console.WriteLine($"Nomi {Nomi} turi {Turi}");

        public void GetAnimalName(string nomi)
        {
            if(Nomi == nomi)
                Console.WriteLine(Nomi + " " + Turi);
            else
                Console.WriteLine("Not found!");
        }
    }
}
