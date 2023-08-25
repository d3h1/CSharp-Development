using System;
using System.Globalization;
using System.Text;

namespace StringBuildersTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Random text"); // Default characters is 16
            StringBuilder sb2 = new StringBuilder("More stuff that is very important", 256);

            // STRINGBUILDER FUNCTIONALITIES

            // MAX SIZE 
            Console.WriteLine("Capacity : {0}", sb2.Capacity);

            // LENGTH OF TEXT 
            Console.WriteLine("Length : {0}", sb2.Length);

            // ADD TEXT
            sb2.AppendLine("\nMore boring text!");

            // DEFINE CULTURE SPECIFIC FORMATTNG
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");

            // APPEND FORMATTED STRING
            string bestCustomer = "Bob Smith";
            sb2.AppendFormat(enUS, "Best customer: {0}", bestCustomer);

            // OUTPUT A STRINGBUILDER
            Console.WriteLine(sb2.ToString());

            // REPLACE A STRING
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());

            // CLEAR A STRINGBUILDER
            sb2.Clear();
            sb2.Append("Random Text");

            // CHECK IF STRING BUILDERS ARE EQUAL
            Console.WriteLine(sb.Equals(sb2));

            // INSERT ANOTHER STRING AT SPECIFIC INDEX
            sb2.Insert(11, " that's great!");
            Console.WriteLine(sb2.ToString());

            // REMOVE A NUMBER OF CHARACTERS STARTING AT INDEX
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());

        }
    }
}