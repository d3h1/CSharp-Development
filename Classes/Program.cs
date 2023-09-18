using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This is the struct version
            Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            // Constructor to create rectangle
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length: {0}", rect2.length);

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            Console.WriteLine("# of Animals {0}", Animal.GetNumAnimals());

            // Creating a static utility class
            Console.WriteLine("Area of Rectangle: {0}", ShapeMath.GetArea("Rectangle", 5, 6));


            // Data types by default cannot be null
            // NULLABLE TYPES -- really needed for things like databases, 
            int? randNum = null;
            if (randNum == null)
            {
                Console.WriteLine("RandNum is null!");
            }
            if (!randNum.HasValue)
            {
                Console.WriteLine("RandNum is null!");

            }

        }
        // STRUCT -- User Defined Type
        // Much like classes, they have fields and methods
        struct Rectangle
        {
            public double length;
            public double width;

            // Constructor method
            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }

            // Calculate Area
            public double Area()
            {
                return length * width;
            }


        }
    }
}