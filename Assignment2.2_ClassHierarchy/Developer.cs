using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2_ClassHierarchy
{
    internal class Developer : Employee
    {
        public Developer() {
            this.Id = Id++;
            this.Salary = 100000;
        }

        public Developer(string mainLang)
        {
            this.Id = Id++;
            this.Salary = 100000;
            MainLang = mainLang;
        }

        public string MainLang { get; set; } = "C#";
        public override void DisplayRole()
        {
            Console.WriteLine($"I am a developer specializing in {MainLang}");
        }
        public new void Greet()
        {
            base.Greet();
            Console.WriteLine("I am also a programmer!");
        }
    }
}
