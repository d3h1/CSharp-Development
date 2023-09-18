using System;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            // Cannot set it directly as we have to use setters now
            cat.SetName("Mike");
            // This was the best way to set up setters and getters
            cat.Sound = "Meow";
            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "Deni";
            Console.WriteLine("{0}'s owner is {1}", cat.GetName(), cat.Owner);

            Console.WriteLine("{0}'s shelter ID is {1}", cat.GetName(), cat.idNum);
            // Since we are getting a static prop, we need to call the class first
            Console.WriteLine("# of animals : {0}", Animal.NumOfAnimals);


        }

    }
}