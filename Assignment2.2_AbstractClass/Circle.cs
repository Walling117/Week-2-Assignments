using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment2._2_AbstractClass
{
    internal class Circle : Shape
    {

        double Radius { get; set; }
        public Circle() {
            this.Id = 1;
            this.Name = "Circle";
            Radius = 1;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            this.Area = Math.PI * Radius * Radius;
            return this.Area;
        }
    }
}
