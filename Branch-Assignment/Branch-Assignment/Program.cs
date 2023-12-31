﻿using System;
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
            else
            {    
                //Taking inputs for package width, height and length
                Console.WriteLine("What is the package width?");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("what is the package height?");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package length?");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                //Adding up total of the three dimnesions to find total and if it exceeds 50
                int totalDimensions = packageWidth + packageHeight + packageLength;
                if (totalDimensions > 50)
                {
                    Console.WriteLine("Package dimensions exceed the limit. Have a good day.");
                }
                else
                {
                    //Multiplying packageWidth, packageHeight and packageLength followed by dividing that total number into the shipping cost.
                    int result = packageWidth * packageHeight * packageLength;
                    int sum = result * packageWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + sum);
                }
                Console.ReadLine();
            }
        }
    }
}