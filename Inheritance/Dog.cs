using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrrr";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        // CUSTOM CONSTRUCTOR
        public Dog (
                    string name = "No Name",
                    string sound = "No Sound",
                    string sound2 = "No Sound 2"
                    ) : base(name, sound)
        {
            // Sound2 has to be done like this because we did not do it like name and sound
            Sound2 = sound2;
        }
    }

    // OVERRIDE -- Will use this function over anything before it 
}
