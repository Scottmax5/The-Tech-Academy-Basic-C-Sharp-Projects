using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main()
        {
            //Instantiate two Employee objects
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            //Assign values to the properties of the first Employee
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Doe";

            //Assign values to the properties of the second Employee
            emp2.Id = 2;
            emp2.FirstName = "Jane";
            emp2.LastName = "Smith";

            //Compare the two Employees using the overloaded "==" operator
            if (emp1 == emp2)
            {
                Console.WriteLine("The Employee objects are equal.");
            }
            else
            {
                Console.WriteLine("The Employee objects are not equal.");
            }

            //Compare the two Employees using the overloaded "!=" operator
            if (emp1 != emp2)
            {
                Console.WriteLine("The Employee objects are not equal.");
            }
            else
            {
                Console.WriteLine("The Employee objects are equal.");
            }
        }
    }
}
