using System;

namespace Functions
{
    public class Program
    {
        // -------- FUNCTIONS ------------
        // <Access Specifier> <Return Type> <Method Name>(Parameters)
        // { <Body> }

        // Access specifier determines wheter the function can be called from another class
        /* 
        PUBLIC : Can be accessed from anther class
        PRIVATE : Cannot be accessed from another class
        PROTECTED : Cannot be accessed by class but can be accessed from derived class 
        */

        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }


        // -------- END OF FUNCTIONS -----------
        static void Main(string[] args)
        {
            SayHello();
        }
    }
}