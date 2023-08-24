using System;
using System.ComponentModel.Design;

namespace Conditonals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("---------CONDITONALS-----------");

            // Relational Operators: > < >= <= == !=
            // Logical Operators: && || !
            int age = 17;
            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school!");
            }
            else if ((age > 7) && (age < 13)) 
            {
                Console.WriteLine("Go to middle school!");
            }
            else if ((age > 14) && (age < 19)) 
            {
                Console.WriteLine("Go to high school!");
            } 
            else
            {
                Console.WriteLine("Go to college!");
            }

            if ((age < 14) || (age > 67)) {
                Console.WriteLine("Not allowed to work!");
            }


            // Set random base Object type array
            object[] randArr = { 1, 2, 3, "Bob", "Sue", 1.2345, true };

            // FOR LOOPS
            Console.WriteLine("\n\n----------FOR LOOPS------------");
            for (int i = 0; i < randArr.Length; i++)
            {
                Console.WriteLine("Index : {0} -> Value : {1}", i, randArr[i]);
            }

            // FOR EACH LOOPS
            Console.WriteLine("--------FOR EACH LOOPS--------");
            int[] randArray = { 1, 2, 3, 4, 5 };
            foreach (int k in randArray)
            {
                Console.WriteLine("{0}", k);
            }
        }
    }
}