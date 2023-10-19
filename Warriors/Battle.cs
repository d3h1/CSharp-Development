using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warriors
{
    // This will act as a utility class - only will have static methods inside of it
    class Battle
    {
        // StartFight()
        // Warrior 1 attacks Warrior 2 and Warrior 2 is damaged and health decreases. 
        // Get attack result
        // Warrior 2 attacks Warrior 1 and Warrior 1 is damaged and health decreases. 
        // Get attack result

        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            // Loops until one is dead.
            while (true)
            {
                // This is fighting for warrior 1
                if (GetAttackResult(warrior1, warrior2) == "Game Over!")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }

                // This is fighting for warrior 2
                if (GetAttackResult(warrior2, warrior1) == "Game Over!")
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
            }
        }


        // GetAttackResult()
        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAttackAmt = warriorA.Attack();
            double warBBlockAmt = warriorB.Block();

            double dmg2warB = warAAttackAmt - warBBlockAmt;

            if (dmg2warB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2warB;
            }
            else dmg2warB = 0;
            

            Console.WriteLine("{0} Attacks {1} and deals {2} damage.\n", warriorA.Name, warriorB.Name, dmg2warB);
            Console.WriteLine("{0} has {1} health.\n", warriorB.Name, warriorB.Health);


            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorious!\n", warriorB.Name, warriorA.Name);

                return "Game Over!";
            }
            else return "Fight Again!";

        }

    }
}
