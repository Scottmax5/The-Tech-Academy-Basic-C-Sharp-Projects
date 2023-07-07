using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Message that will first appear when program is ran.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            //Prompt for user to type in number, will error and return message if package is oversized.
            Console.WriteLine("What is your package weight?");
                int packageWeight = Convert.ToInt32(Console.ReadLine());
                if (packageWeight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                }

            //Prompt for user to type in number, will error and return message if package is oversized.
            Console.WriteLine("What is the package width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                if (packageWidth > 50)
                {
                    Console.WriteLine("Package too wide to be shipped via Package Express. Have a good day.");
                }

            //Prompt for user to type in number, will error and return message if package is oversized.
            Console.WriteLine("what is the package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                if (packageHeight > 50)
                {
                    Console.WriteLine("Package too tall to be shipped via Package Express. Have a good day.");
                }

            //Prompt for user to type in number, will error and return message if package is oversized.
            Console.WriteLine("What is the package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                if (packageLength > 50)
                {
                    Console.WriteLine("Package too long to be shipped via Package Express. Have a good day.");
                }

            //Multiplying packageWidth, packageHeight and packageLength followed by dividing that total number into the shipping cost.
            int result = packageWidth * packageHeight * packageLength / 100 ;
            Console.WriteLine("Your estimated total for shipping this package is: $"+ result);

            Console.ReadLine();
        }
    }
}
