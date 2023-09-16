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

        // If name is provided but no sound
        public Animal(string name = "No Name")
        {
            // THIS -- Refers to the objects name
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }



    }
}
