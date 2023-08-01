using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    //Adding inheritance for IQuittable to Employee
    class Employee : IQuittable
    {
        //Implemented Quit method with writeline to tell user
        public void Quit()
        {
            Console.WriteLine("Employee has quit.");
        }
    }
}
