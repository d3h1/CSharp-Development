using System;

namespace Warriors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new Warrior("Warrior 1", 100, 26, 10);
            //Warrior loki = new Warrior("Loki", 100, 26, 10);
            MagicWarrior loki = new MagicWarrior("Warrior 2", 75, 20, 10, 50);


            Battle.StartFight(thor, loki);

        }
    }
}