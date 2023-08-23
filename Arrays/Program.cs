using System;

namespace Arrays
{
    public class Program
    {
        // FUNCTIONS
        static void PrintArrays(int[] intArray, string mess)
        {
            foreach (int k in intArray)
            {
                Console.WriteLine("{0} : {1}", mess, k);
            }
        }

        // FUNCTION END
        static void Main(string[] args)
        {
            Console.WriteLine("---------REGULAR ARRAYs----------");
            // INT ARRAY
            int[] favNums = new int[3];
            //ADD TO ARRAY
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

            // MULTI DIMENSIONAL ARRAY
            Console.WriteLine("---------MULTI DIMENSIONAL ARRAYs----------");
            string[,] custName = new string[2, 2] { { "Bob", "Smith" }, { "Sally", "Smith" } }; // Created rows by 2x2
            Console.WriteLine("Multi Dimensional Value : {0}", custName.GetValue(1, 0));

            // For loop in a mutlie dimensional array can be a nested for loop
            for (int j = 0; j < custName.GetLength(0); j++)
            {
                for (int k = 0; k < custName.GetLength(0); k++)
                {
                    Console.WriteLine("{0} ", custName[j, k]);
                }
                Console.WriteLine();
            }

            int[] randNums = { 1, 4, 7, 6 };
            PrintArrays(randNums, "ForEach");
        }
    }
}