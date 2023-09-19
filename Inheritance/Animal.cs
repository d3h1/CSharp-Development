using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // THIS IS NOT THE BEST WAY TO DO GETTERS AND SETTERS 
    class Animal
    {
        private string name;
        // Allows access outside of subclass unlike private
        protected string sound;

        // INHERITANCE -- If we use this -- go get all props from this animal and pout insidde
        // anoter class, this is called a relationship

        // DELEGATE
        protected AnimalIDInfo animalIDInfo = new AnimalIDInfo();

        public void SetAnimalIDInfo(int idNum, string owner)
        {
            animalIDInfo.IDNum = idNum;
            animalIDInfo.Owner = owner; 
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has the ID of {animalIDInfo.IDNum} and is owner by {animalIDInfo.Owner}");
        }

        // Virtual allows for overwriting in the subclass
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }


        // DEFAULT CONSTRUCTOR if nothing is set
        public Animal() : this("No Name", "No Sound") { }

        // Constructor called only if a name only is passed 
        public Animal(string name) : this(name, "No Sound") { }

        // Constructor to take away all error messages in program with 'numOfAnimals' is not null here
        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
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
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "No Name!";
                    Console.WriteLine("Name cannot have digits!");
                }
                else { name = value; }
                
                
            }
        }

        // INNER CLASSES -- These are normally considered helper classes for the outer class
        // Judging animals health
        public class AnimalHealth
        {
            public bool HealthyWeight(double height, double weight)
            {
                double calc = height / weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }
        }



    }
}
