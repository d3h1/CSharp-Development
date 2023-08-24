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

            Console.WriteLine("\n-------------------------------------------\n");

            // ARRAY SORTING
            int[] numRand = { 1, 2, 34, 5, 8, 4, 3 };
            Array.Sort(numRand);

            // ARRAY REVERSE
            Array.Reverse(numRand);
            Console.WriteLine("1 at index: {0}", Array.IndexOf(numRand, 1));

            // ARRAY SET VALUE
            numRand.SetValue(0, 1);

            // ARRAY COPY TO OTHER
            int[] srcArray = { 1, 2, 3 };
            int[] dstArray = new int[2];
            int startInd = 0;
            int length = 2;

            Array.Copy(srcArray, startInd, dstArray, 0, length);
            PrintArrays(dstArray, "Copy");

            // ARRAY CREATION
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("Copy to: {0} ", m);
            }

            //// ARRAY FIND
            //int[] numArray = { 1, 11, 22 };
            //Console.WriteLine("> 10 : {0}", Array.Find(numArray, GT10));
        }
    }
}