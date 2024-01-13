using Shifoxona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Shifoxona.Repository
{
    public interface IPerson
    {
        List<Person> GetPersons();
        void GetPerson(int id);
        void CreatePerson(Person newPerson);
        bool DeletePerson(int id);
    }
}
