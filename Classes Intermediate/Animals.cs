using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // THIS IS NOT THE BEST WAY TO DO GETTERS AND SETTERS 
    class Animal
    {
        // FIELDS
        // PRIVATE to only be accessed through their getters and setters 
        // If marked as private, not accessible from subclasses. 
        private string name;
        private string sound;

        // STATIC FIELD
        public static int numOfAnimals = 0; // Static belongs to the class
        // CONSTANTS
        public const string SHELTER = "Deni's Home For Animals";
        // Define an ID number for each animal
        //READONLY -- Can be set and cannot be changed
        public readonly int idNum;

        // DEFAULT CONSTRUCTOR if nothing is set
        public Animal() : this("No Name", "No Sound") { }

        // Constructor called only if a name only is passed 
        public Animal(string name) : this(name, "No Sound") { }

        // Constructor to take away all error messages in program with 'numOfAnimals' is not null here
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 214748249);
        }
     
        public void MakeSounds()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }

        // SETTERS or MUTATORS -- Protect attributes.
        // If bad name pass, we can go ahead and erject that
        // THIS IS NOT THE BEST WAY TO DO GETTERS AND SETTERS -- You should do it all in like Sound
        public void SetName(String name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name cannot contain numbers!");
            }
        }

        // GETTERS or ACCESSORS - PRovide custom output
        public string GetName()
        {
            return name;
        }

        // THIS IS THE BEST WAY TO SET UP SETTERS AND GETTERS 
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound!";
                    Console.WriteLine("Sound is too long!");
                }
                else
                {
                    sound = value;
                }
            }
        }

        // GETTERS or SETTERS generated for us
        public string Owner { get; set; } = "No Owner";

        // Store more than one number of animals
        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set { numOfAnimals += value; }
        }


    }
}
