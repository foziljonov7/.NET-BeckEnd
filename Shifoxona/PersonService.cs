using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona
{
    public class PersonService : AbstractPerson
    {
        private static List<Person> person = new List<Person>()
        {
            new Person
            {
                Id = 1,
                Fullname = "Boqijon Nematov",
                PhoneNumber = "+998907411342",
                Age = 20,
                Location = "Namangan",
                Disease = "Tumov"
            }
        };
        public override List<Person> CreatePerson(Person newPerson)
        {
            if(newPerson != null)
            {
                var p = new Person
                {
                    Id = newPerson.Id,
                    Fullname = newPerson.Fullname,
                    Age = newPerson.Age,
                    PhoneNumber = newPerson.PhoneNumber,
                    Location = newPerson.Location,
                    Disease = newPerson.Disease
                };

                person.Add(p);
            }
            else
            {
                Console.WriteLine("Null reference");
            }
            return person;
        }

        public override bool DeletePerson(int id)
        {
            var p = person.Find(p => p.Id == id);

            if(p != null)
            {
                person.Remove(p);
                Console.WriteLine("Malumot o'chirildi");
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void GetPerson(int id)
        {
            var p = person.Find(p => p.Id == id);

            if(p != null)
            {
                foreach(var i in person)
                    Console.WriteLine($"{i.Id} {i.Fullname} {i.PhoneNumber} {i.Age} {i.Location} {i.Disease}");
            }
            else
            {
                Console.WriteLine("null");
            }
        }

        public override List<Person> GetPersons()
        {
            return person;
        }
    }
}
