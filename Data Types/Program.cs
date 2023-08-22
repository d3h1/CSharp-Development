using System;

namespace Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Bools
            bool canIVote = true;

            // Integers 
            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            // Longs
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);

            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigValue = 3.0000000000000000000000000000011M;
            // {0} is a placeholder for these numbers 
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigValue);

            // Decimals
            Console.WriteLine("Biggest Decimal: {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal: {0}", Decimal.MinValue);

            // Doubles - 64 bit flow types
            Console.WriteLine("Biggest Double: {0}", Double.MaxValue);
            Console.WriteLine("Smallest Double: {0}", Double.MinValue);

            double dblPiVal = 3.14159265359;
            double dblBigValue = 3.00000000002;

            Console.WriteLine("DBL : PI + bigVal = {0}", dblPiVal + dblBigValue);

            // Floats 
            Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            Console.WriteLine("Smallest Float: {0}", float.MinValue);

            double fltPiVal = 3.141592F;
            double fltBigValue = 3.000002F;

            Console.WriteLine("FLT : PI + bigVal = {0}", fltPiVal + fltBigValue);
        }
    }
}