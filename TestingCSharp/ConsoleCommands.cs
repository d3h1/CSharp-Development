using System;

namespace TestingCSharp
{
    public class ConsoleCommands
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Hello World!");
        }
    }
}