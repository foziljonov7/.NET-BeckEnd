using Shifoxona.Models;
using Shifoxona.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Services
{
    public class EmployeeService : IEmployee
    {
        private static List<Employee> employee = new List<Employee>();
        public void CreateEmployee(Employee newEmployee)
        {
            try
            {
                var e = new Employee
                {
                    Id = newEmployee.Id,
                    Fullname = newEmployee.Fullname,
                    Career = newEmployee.Career,
                    PhoneNumber = newEmployee.PhoneNumber,
                    Location = newEmployee.Location,
                    Age = newEmployee.Age
                };

                employee.Add(e);

                Console.WriteLine($"{e.Id} successfully saved");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Invalid operation {ex}");
            }
        }

        public bool DeleteEmployee(int id)
        {
            var e = employee.Find(e => e.Id == id);
            if(e != null)
            {
                employee.Remove(e);
                Console.WriteLine($"{e.Id} successfully deleted");
                return true;
            }
            else
            {
                Console.WriteLine($"{e.Id} invalid operation");
                return false;
            }
        }

        public void GetCareer(string career)
        {
            if (career != null && employee != null)
            {
                foreach (var e in employee)
                {
                    if (e.Career == career)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }

        public void GetEmployee(int id)
        {
            var e = employee.Find(e => e.Id == id);
            Console.WriteLine(e.ToString());
        }

        public List<Employee> GetEmployees()
        {
            return employee;
        }
    }
}
