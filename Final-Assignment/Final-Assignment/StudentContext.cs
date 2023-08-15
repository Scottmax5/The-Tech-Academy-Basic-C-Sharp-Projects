using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Final_Assignment;


namespace Final_Assignment
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("Data Source=DESKTOP-G3FDMR8\\SQLEXPRESS01;Integrated Security=True")
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}