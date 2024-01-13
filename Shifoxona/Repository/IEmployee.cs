using Shifoxona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifoxona.Repository
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        void CreateEmployee(Employee newEmployee);
        void GetEmployee(int id);
        bool DeleteEmployee(int id);
        void GetCareer(string career);
    }
}
