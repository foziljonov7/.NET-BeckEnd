using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    public class Course
    {
        public Course(int id, string name, string teacher)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
    }
}
