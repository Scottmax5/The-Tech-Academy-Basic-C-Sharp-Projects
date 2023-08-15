using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Final_Assignment;


namespace Final_Assignment
{
   public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {
                Console.WriteLine("Add student to database.");
                context.Database.CreateIfNotExists();

                //Adding a new student
                var newStudent = new Student
                {
                    Id = 1,
                    FirstName = "Scott",
                    LastName = "Ainsworth",
                };

                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added to database.");
            }
        }
    }
}