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
        static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }

        // PASSING UNKNOWN AMOUNT OF PARAMS
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        // PASS IN PARAMS IN ANY ORDER WHEN WE USE NAMED PARAMS
        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);
        }

        // METHOD OVERLOADING - Create functions with exactly the same name but they can actually be asked differnet types of PARAMS
        static double GetSum2(double x = 1, double y = 1)
        {
            return x + y;
        }
        static double GetSum2(string x = "1", string y = "1")
        {
            double dblX = Convert.ToDouble(x);
            double dblY = Convert.ToDouble(y);
            return dblX + dblY;
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

            //Console.WriteLine("1 + 2 + 3 + 4 + 5 = {0}", GetSumMore(1, 2, 3, 4, 5));

            //PrintInfo(zipCode: 91202, name: "Deni");

            //Console.WriteLine("5.0 + 4.0 = {0}", GetSum2(5.0, 4.0));
            //Console.WriteLine("5.0 + 4.0 = {0}", GetSum2("5.0", "4.0"));



        }
    }
}