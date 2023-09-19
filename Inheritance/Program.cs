using System;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Wooooof";

            whiskers.MakeSound();
            grover.MakeSound();
            whiskers.SetAnimalIDInfo(123456, "Sally Smith");
            grover.SetAnimalIDInfo(143621, "Owen Wilson");

            whiskers.GetAnimalIDInfo();
            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 46));

            //Cerating more animal types
            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Wooooffff",
                Sound2 = "grrrrrrrrrr"
            };

            spot.MakeSound();
            

        }
    }
}
