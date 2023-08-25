using System;

namespace Functions
{
    public class Program
    {
        // -------- FUNCTIONS ------------
        // <Access Specifier> <Return Type> <Method Name>(Parameters)
        // { <Body> }

        // Access specifier determines wheter the function can be called from another class
        /* 
        PUBLIC : Can be accessed from anther class
        PRIVATE : Cannot be accessed from another class
        PROTECTED : Cannot be accessed by class but can be accessed from derived class 
        */

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }

        // PASSED TWO VALUES AND SUM THEM
        static double GetSum(double x = 1, double y = 1)
        {
            return x + y;
        }


        // -------- END OF FUNCTIONS -----------
        static void Main(string[] args)
        {
            //SayHello();
            double x = 5;
            double y = 4;

            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, GetSum(x, y));
        }
    }
}