using Abstract_Classes_and_Methods;
using System;

namespace AbstractClassesAndMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Sometimes we want to define a class that we dont want unstatiated ... 
            // WE DO NOT WANT AN OBJECT CREATED FOR IT basically

            // We will use an Abstract Class
            // STORE SHAPES IN A SHAPE ARRAY as long as shapes inside store subclass using SHAPE
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            // Cycle through shapes and their areas
            foreach (Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                // AS to check if object is of specific type
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This is not a Circle!");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This is not a Rectangle!");
                }
            }

            // POLYMORPHISM
            // Store any class as a base class and call subclass methods even if they dont exsist in base class but you have to go in and cast them
            object circ1 = new Circle(4);

            Circle circ2 = (Circle) circ1;
            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
        }
    }
}