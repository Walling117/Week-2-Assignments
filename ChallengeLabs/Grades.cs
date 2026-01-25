using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeLabs
{
    internal static class Grades
    {
        public static void StartGradesMenu()
        {
            Student student = new Student();
            Console.Clear();
            Console.Write("Roll number of student: ");
            student.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Marks in Physics: ");
            student.MarksInPhysics = Convert.ToDouble(Console.ReadLine());
            Console.Write("Marks in Chemistry: ");
            student.MarksInChemistry = Convert.ToDouble(Console.ReadLine());
            Console.Write("Marks in Computer Apllication: ");
            student.MarksInComputerApplication = Convert.ToDouble(Console.ReadLine());

            student.CalculateTotalMarks();
            student.CalculatePercentage();
            student.CalculateDivision();
            student.DisplayStudent();
            Console.ReadKey();
        }
    }


    internal struct Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }  
        public double MarksInPhysics { get; set; }
        public double MarksInChemistry { get; set; }
        public double MarksInComputerApplication { get; set; }
        public double TotalMarks { get; set; }
        public double Percentage { get; set; }
        public string Division { get; set; }

        public void CalculateTotalMarks()
        {
            TotalMarks = MarksInPhysics + MarksInChemistry + MarksInComputerApplication;
        }
        public void CalculatePercentage()
        {
            Percentage = TotalMarks / 3;
        }
        public void CalculateDivision()
        {
            if (Percentage >= 90)
                Division = "First";
            else if (Percentage >= 80 && Percentage < 90)
                Division = "Second";
            else if (Percentage >= 70 && Percentage < 80)
                Division = "Third";
            else if (Percentage >= 60 && Percentage < 70)
                Division = "Fourth";
            
        }

        public void DisplayStudent()
        {
            Console.Clear();
            Console.WriteLine($"Roll No: {RollNumber}\nName: {Name}\nMarks in Physics: {MarksInPhysics}\tMarks in Chemistry: {MarksInChemistry}\tMarks in Computer Apllication: {MarksInComputerApplication}");
            Console.WriteLine($"Total Marks {TotalMarks}\tPercentage: {Percentage}\tDivision: {Division}");
        }
    }
}
