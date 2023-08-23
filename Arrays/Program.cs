using System;

namespace Arrays
{
    public class Program
    {
        // FUNCTIONS
        static void PrintArray(int[] intArray, string message)
        {

        }


        // END OF FUNCTIONS

        static void Main(string[] args)
        {
            // INT ARRAY
            int[] favNums = new int[3];
            //Add to arr
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);

            // STRING ARRAY
            string[] customers = { "Bob", "Sally", "Sue" };

            // USING VAR
            var employees = new[] { "Mike", "Paul", "Rick" };

            // BASE OBJECT ARRAYS - base tpye of all other types
            object[] rndArr = { "Paul", 45, 1.234 };
            Console.WriteLine("Random Array 0 : {0}", rndArr[0].GetType());
            Console.WriteLine("Array Size: {0}", rndArr.Length);

            // FOR LOOP IN ARRAYS
            for (int j = 0; j < rndArr.Length; j++)
            {
                Console.WriteLine("Index : {0} -> Value : {1}",
                    j, rndArr[j]);
            }

            // Multi Dimensional Array
            Console.WriteLine("---------MULTI DIMENSIONAL ARRAY----------");
                string[,] custName = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } }; // Created rows by 2x2
            Console.WriteLine("Multi Dimensional Value : {0}", custName.GetValue(1, 0));

            for (int j = 0; j < custName.GetLength(0); j++)
            {
                for (int k = 0; k < custName.GetLength(0); k++)
                {
                    Console.WriteLine("{0} ", custName[j, k]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 7, 6 };

        }
    }
}