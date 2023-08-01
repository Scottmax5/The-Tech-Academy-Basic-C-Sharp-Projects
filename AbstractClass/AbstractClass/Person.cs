using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Create an abstract class "Person" with two string properties: firstName and lastName
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        //Give it the method SayName().
        public abstract void SayName();
    }
}
