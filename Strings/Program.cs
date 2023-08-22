using System;

namespace Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Formatting
            Console.WriteLine("-----------BASIC FORMATTING--------");
            Console.WriteLine("Currency : {0:c}", 23.455); // Currency
            Console.WriteLine("Pad with zeroes : {0:d4}", 23); // Pad with 0's
            Console.WriteLine("3 Decimals : {0:f3}", 23.45545643564); // Only three decimals
            Console.WriteLine("Commas : {0:n4}\n\n", 2300); // Auto commas

            // STRINGS
            Console.WriteLine("-----------STRING FORMATTING--------");
            string randString = "This is a string";
            // String Length
            Console.WriteLine("String Length: {0}",
                randString.Length);
            // String Contains
            Console.WriteLine("String Contains is: {0}",
                randString.Contains("is"));
            // String index
            Console.WriteLine("Index of is: {0}",
                randString.IndexOf("is"));
            // String remove
            Console.WriteLine("Remove String: {0}",
                randString.Remove(10, 6));
            // String add
            Console.WriteLine("Insert String: {0}",
                randString.Insert(10, "short "));
            // String replace
            Console.WriteLine("Replace String: {0}",
                randString.Replace("string", "sentence"));
            // String compare
            Console.WriteLine("Compare String A to B: {0}",
                String.Compare("A", "B",
                StringComparison.OrdinalIgnoreCase)); // This will ignore uppercase or lower case
            // HOW IT WORKS
            // < 0 : str1 precededs str2
            // = 0 : Zero
            // > 0 : str2 precedes str1

            // String other compare
            Console.WriteLine("A = a: {0}",
                String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));

            // String padding left
            Console.WriteLine("Pad Left : {0}",
                randString.PadLeft(20, '.'));
            // String padding right
            Console.WriteLine("Pad Right : {0}",
                randString.PadRight(20, '.'));

            // String whitespace trim
            Console.WriteLine("Trim : {0}",
                randString.Trim());

            // String uppercase
            Console.WriteLine("Uppercase : {0}",
                randString.ToUpper());
            // String lowercase
            Console.WriteLine("Lowercase : {0}",
                randString.ToLower());
            Console.WriteLine("\n-----------STRING FORMAT NEW--------");
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field");
            Console.Write(newString + "\n");
            // \' \" \\ \t \a




        }
    }
}