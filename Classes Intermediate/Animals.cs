using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // We will use this to model real world objects
    class Animal
    {
        // FIELDS
        public string name;
        public string sound;

        // STATIC FIELD
        static int numOfAnimals = 0; // Static belongs to the class

        // CONSTRUCTOR -- Allows for default values
        public Animal()
        {

            name = "No Name";
            sound = "No Sound";
            // Track number of animals ever made
            numOfAnimals++;
        }

        // THIS -- Refers to the objex
        // If name is provided but no sound
        public Animal(string name = "No Name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }

        // Setting up default values in the params
        public Animal(string name = "No name", string sound = "No sound")
        {
            // This will assign the default or the value passed through
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        // Capabilities of class can come from Methods
        // METHODS -- Special functions inside of classes
        public void MakeSounds()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        // Get total amount of animals created
        // Static because numOfAnimals is static 
        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }


    }
}
