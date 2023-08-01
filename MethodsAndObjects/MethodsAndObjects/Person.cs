using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
        //Create a class called Person and give it two properties, each of data type string
        //One called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called SayName() that takes no paramters and simply writes
        //the person's full name to console in the format of: "Name: [full name]"
        public void SayName()
        {
            Console.Write("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
