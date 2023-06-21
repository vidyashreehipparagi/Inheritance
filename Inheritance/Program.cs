

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager("Rohan", 28000, 3500);
            salesManager.CalculateSalary();
            Console.WriteLine(salesManager);// ToString() get called implicitly 

            Employee employee = new Employee("Suraj", 23000);
            employee.CalculateSalary();
            Console.WriteLine(employee);

        }
    }
}
