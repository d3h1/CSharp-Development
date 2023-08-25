using System;

namespace ExceptionHandling
{
    public class Program
    {
        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }

        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero!");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            // Should'nt use this until its the last one because it will give out all exceptions or errors
            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            // This helps if you a database connection and you want to close it always
            // IF YOU ALWAYS WANT TO PROVIDE SOME TYPE OF CLEANUP
            finally
            {
                Console.WriteLine("Cleaning up!");
            }
        }
    }
}