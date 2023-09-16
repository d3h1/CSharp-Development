using System;
using System.ComponentModel.DataAnnotations;

namespace EnumeratedTypes
{
    public class Program
    {
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Yellow,
            Red
        }

        // This function will output the color represented what we pass into it --- Also will print the code associated with it
        static void PaintCar(CarColor cc)
        {
            Console.WriteLine("The car was painted: {0} with the code {1}", cc, (int)cc); 
        }

        static void Main(string[] args)
        {
            // ENUMERATED TYPES - Whenever you want to create a data type that is going to be of a limited number of possible values
            // Operate kind of like key value pairs -- ALLOW US TO USE SYMBOLIC NAMES WITH DATA
            CarColor car1 = CarColor.Blue;
            PaintCar(car1);
        }
    }

}