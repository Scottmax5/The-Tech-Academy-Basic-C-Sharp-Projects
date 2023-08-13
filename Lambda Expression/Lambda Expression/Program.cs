using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees
            //At least two employees should have the first name "Joe"
            List<Employee> campus = new List<Employee>()
            {
                new Employee() {Id = 1, firstName = "Joe", lastName = "Schmo"},
                new Employee() {Id = 2, firstName = "Joe", lastName = "Thomas"},
                new Employee() {Id = 3, firstName = "Jimbob", lastName = "Coot"},
                new Employee() {Id = 4, firstName = "Danny", lastName = "Dimes"},
                new Employee() {Id = 5, firstName = "SaQuads", lastName = "Barkley"},
                new Employee() {Id = 6, firstName = "George", lastName = "Title"},
                new Employee() {Id = 7, firstName = "Joe", lastName = "Joesephson"},
                new Employee() {Id = 8, firstName = "Maria", lastName = "Schmo"},
                new Employee() {Id = 9, firstName = "Maria", lastName = "Rodriguez"},
                new Employee() {Id = 10, firstName = "Stephanie", lastName = "Stevens"},
            };
            //Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Do the same thing again, but this time with a lambda expression
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
