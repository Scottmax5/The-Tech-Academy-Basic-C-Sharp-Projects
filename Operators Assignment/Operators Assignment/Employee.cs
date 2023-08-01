using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee
    {
        //firstName and lastName properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //== Checks if both employees are equal
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //If both objects are null, or both have the same reference, they are equal
            if (ReferenceEquals(emp1, emp2))
                return true;

            //If one of the objects is null, they are not equal
            if (emp1 is null || emp2 is null)
                return false;

            //Compare the Id properties to determine equality
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
