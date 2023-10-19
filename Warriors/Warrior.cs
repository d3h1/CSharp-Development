using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    class Warrior
    {
        // Warrior is going to have diff attributes
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Random number generations
        Random rnd = new Random();

        // Create constructor for warrior
        public Warrior(string name = "Warrior", 
            double health = 0,
            double attackMax = 0, 
            double blockMax = 0) 
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // Giving the ability to generate a random attack ammount
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }
        
        // Giving the ability to generate a random block ammount along with an override
        public virtual double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
