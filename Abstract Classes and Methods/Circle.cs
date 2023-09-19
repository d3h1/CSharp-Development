using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    // We are INHERITING from shape class
    class Circle : Shape
    {
        // GETTERS and SETTERS
        public double Radius { get; set; }

        // CONSTRUCTOR
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        // Need to OVERRIDE Area method as circle is a differnet way of doing it
        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        // Need to OVERRIDE get info section
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a radius of {Radius}");
        }
    }
}
