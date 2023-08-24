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

            // NOT TRUE
            Console.WriteLine("!true = " + (!true));

            // TURNERY OPERATOR
            bool canDrive = age >= 16 ? true : false;

            // SWITCH
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to day care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to pre school");
                    break;
                case 5:
                    Console.WriteLine("Go to kindergarten");
                    break;
                default:
                    Console.WriteLine("Go to another school");
                    goto OtherSchool;
            }

        OtherSchool:
            Console.WriteLine("High school!\n");

            // Comparing two strings
            string name2 = "deni";
            string name3 = "deni";
            if (name2.Equals(name3, StringComparison.Ordinal))
            {
                Console.WriteLine("Names are equal!");
            }


            // Set random base Object type array
            object[] randArr = { 1, 2, 3, "Bob", "Sue", 1.2345, true };

            // FOR LOOPS
            Console.WriteLine("\n\n----------FOR LOOPS------------");
            for (int a = 0; a < randArr.Length; a++)
            {
                Console.WriteLine("Index : {0} -> Value : {1}", a, randArr[a]);
            }

            // FOR EACH LOOPS
            Console.WriteLine("--------FOR EACH LOOPS--------");
            int[] randArray = { 1, 2, 3, 4, 5 };
            foreach (int k in randArray)
            {
                Console.WriteLine("{0}", k);
            }

            // WHILE LOOPS
            Console.WriteLine("--------WHILE LOOPS--------");
            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    i++;
                    continue;
                }
                else if (i == 9)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }

            // DO WHILE LOOPS
            Console.WriteLine("--------DO WHILE LOOPS--------");
            Random rnd = new Random();
            int secretNum = rnd.Next(1,11);
            int numGuessed = 0;
            Console.WriteLine("Random Number : {0}", secretNum);

            do
            {
                Console.WriteLine("Enter a number between 1 and 10 : ");
                numGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNum != numGuessed);

            Console.WriteLine("You guessed it. It was {0}", secretNum);
        }
    }
}