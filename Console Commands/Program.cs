using System; // Import a namespace named system

namespace TestingCSharpV1
{
    public class ConsoleCommands
    {
        // Can run without creating an object previously
        static void Main(string[] args)
        {


            // Trying out console commands
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hello There!");

            // How we do inputs
            Console.Write(" What is your name? ");
            string name = Console.ReadLine();
            // Kind of like python f strings
            Console.WriteLine($"Hello {name}");

        }
    }
}