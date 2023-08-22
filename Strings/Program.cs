using System;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Formatting
            Console.WriteLine("Currency : {0:c}", 23.455); // Currency
            Console.WriteLine("Pad with zeroes : {0:d4}", 23); // Pad with 0's
            Console.WriteLine("3 Decimals : {0:f3}", 23.45545643564); // Only three decimals
            Console.WriteLine("Commas : {0:n4}", 2300); // Auto commas
        }
    }
}