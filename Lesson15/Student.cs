using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    public class Student 
    {
        public Student(int id, string fullname, string location)
        {
            Id = id;
            Fullname = fullname;
            Age = 18;
            Location = location;
        }

        public int Id { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public void GetStudent()
        {
            Console.WriteLine($" Id: {Id} to'liq ismi: {Fullname} " +
                $" yoshi: {Age} manzili: {Location}");
        }
        public void GetStudentById(int id)
        {
            if (Id == id)
                Console.WriteLine($" Id: {Id} to'liq ismi: {Fullname} " +
                $" yoshi: {Age} manzili: {Location}");
            else
                Console.WriteLine("Null");
        }
    }
}