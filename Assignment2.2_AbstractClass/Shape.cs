using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2_AbstractClass
{
    internal abstract class Shape
    {
      public int Id { get; set; }  
      public double Area { get; set; } = 0;
      public string Name { get; set; }  
        public string Color { get; set; }


        public abstract double CalculateArea();

    }
}
