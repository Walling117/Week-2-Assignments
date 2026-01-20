using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2_ClassHierarchy
{
    internal class Manager : Employee
    {
        int TeamSize { get; set; } = 2;

        Manager() {
            this.Id = Id++;
            this.Salary = 120000;
            this.TeamSize = 2;
        }
        Manager(double salary, int teamSize)
        {
            this.Id = Id++;
            this.Salary = salary;
            this.TeamSize = teamSize;
        }
        public override void DisplayRole()
        {
            Console.WriteLine($"I am a manager of {TeamSize}");
        }
        public new void Greet()
        {
            base.Greet();
            Console.WriteLine("I manage people");
        }
    }
}
