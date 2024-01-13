using Shifoxona.Models;
using Shifoxona.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Services
{
    public class PersonService : IPerson
    {
        private readonly RoomService room;
        private static List<Person> person = new List<Person>();
        public void CreatePerson(Person newPerson)
        {
            try
            {
                var p = new Person
                {
                    Id = newPerson.Id,
                    Fullname = newPerson.Fullname,
                    PhoneNumber = newPerson.PhoneNumber,
                    Age = newPerson.Age,
                    RoomId = newPerson.RoomId,
                    Disease = newPerson.Disease,
                    Location = newPerson.Location
                };

                person.Add(p);
                Console.WriteLine($"{p.Id} Successfully saved");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Invalid operation {ex}");
            }
        }

        public bool DeletePerson(int id)
        {
            var p = person.Find(p => p.Id == id);
            if(p != null)
            {
                person.Remove(p);
                Console.WriteLine($"{p.Id} Successfully deleted");
                return true;
            }
            else
            {
                Console.WriteLine($"{p.Id} invalid operation");
                return false;
            }
        }

        public void GetPerson(int id) //12 
        {
            var p = person.Find(p => p.Id == id);
            if(p is not null)
            {
                Console.WriteLine(p.ToString());
                room.GetRoom(p.RoomId);
            }
            else
                Console.WriteLine("Invalid operation");
        }

        public List<Person> GetPersons()
        {
            return person;
        }
    }
}
