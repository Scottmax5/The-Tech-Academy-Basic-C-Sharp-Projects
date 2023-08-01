using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = new Employee();
            //Using the quit method
            quittableEmployee.Quit();
            Console.ReadLine();
        }
    }
}
