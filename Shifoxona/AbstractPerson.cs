using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona
{
    public abstract class AbstractPerson
    {
        public abstract List<Person> GetPersons();
        public abstract List<Person> CreatePerson(Person newPerson);
        public abstract bool DeletePerson(int id);
        public abstract void GetPerson(int id);
    }
}
