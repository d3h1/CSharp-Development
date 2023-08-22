using System;

namespace Casting
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Specific to each DATA TYPE

            // BOOL
            bool boolFromStr = bool.Parse("true");

            // INT
            int intFromStr = int.Parse("100");

            // DOUBLE
            double dblFromStr = double.Parse("1.234");

            // STRING
            string strVal = dblFromStr.ToString();

            Console.WriteLine($"Data type: {strVal.GetType()}");

            // EXPLICIT CONVERSION if you are losing data i.e: DOUBLE TO INTEGER 
            double dblNum = 12.345;
            // DOUBLE -> INTEGER explicit because we are losing decimals when converting

            Console.WriteLine($"Integer: {(int)dblNum}"); // Whatever integer you are trying to convert
                                                          // to has to go before the variable you are looking at 

            // IMPLICIT CONVERSION if smaller size type is being converted into bigger data type INT TO LONG
            int intNum = 10;
            long longNum = intNum;
            Console.WriteLine(longNum);
        }
    }
}

