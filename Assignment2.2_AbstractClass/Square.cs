using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._2_AbstractClass
{
    internal class Square : Shape
    {
        double Side { get; set; }   
        public Square() {
            this.Id = 2;
            this.Name = "Square";
            Side = 1;
        }

        public Square(double side)
        {
            this.Id = 2;
            this.Name = "Square";
            this.Side = side;
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }

}
