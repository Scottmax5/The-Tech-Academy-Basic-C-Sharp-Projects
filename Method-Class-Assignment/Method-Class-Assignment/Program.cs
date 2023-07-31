using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethod mathOperation = new MathMethod();

            // Call the method in the class, passing in two numbers
            mathOperation.mathOp(5, 10);

            // Call the method in the class, specifying the parameters by name
            mathOperation.mathOp(a: 7, b: 20);

            Console.ReadLine();
        }
    }
}