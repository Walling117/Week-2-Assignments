using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2._3_IOData
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public new StringBuilder ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("".PadLeft(120, '-'));
            sb.Append($"\nName: {Name}\tAge: {Age}\t\tAddress: {Address}\n");
            sb.Append("".PadLeft(120,'-'));
            return sb;
        }
    }
}
