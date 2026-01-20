using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2_ClassHierarchy
{
    internal abstract class Employee
    {
        public static int employeeCount = 0;
        public string Fname { get; set; } = string.Empty;
        public string Lname { get; set; } = string.Empty;
        public int Id { get; set; }
        public double Salary { get; set; }

        public abstract void DisplayRole();
       
        public virtual void Greet()
        {
            Console.WriteLine($"Hello, I am {Fname} {Lname}! My employee id is {Id}. My salary is {Salary}");
        }

    }
}
