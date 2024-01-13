using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Career { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"{Id} {Fullname} {Career} {PhoneNumber} {Age} {Location}";
        }
    }
}
