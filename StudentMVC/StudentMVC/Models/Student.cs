using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstMVC.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentContextDB")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}