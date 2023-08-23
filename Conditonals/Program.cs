using System;

namespace Conditonals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("---------CONDITONALS-----------\n");

            // Set random base Object type array
            object[] randArr = { 1, 2, 3, "Bob", "Sue", 1.2345, true };

            // FOR LOOPS
            Console.WriteLine("----------FOR LOOPS------------");
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