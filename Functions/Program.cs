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

        // OUT PARAMETER
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        // PASS BY REFERENCE -- change value inside of function and then change outside of function as well
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }



        // -------- END OF FUNCTIONS -----------
        static void Main(string[] args)
        {
            //SayHello();

            /*
            double x = 5;
            double y = 4;
            Console.WriteLine("Sum of {0} and {1} is {2}", x, y, GetSum(x, y));
            */

            /*
            DoubleIt(15, out int solution);
            Console.WriteLine("15 * 2 = {0}", solution);
            */

            /*
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap -> num1 : {0} || num2 : {1}", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap -> num1 : {0} || num2 : {1}", num3, num4);
            */

            /**/

        }
    }
}