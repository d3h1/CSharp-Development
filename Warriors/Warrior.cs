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
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double BlockMax { get; set; }

        // Random number generations
        Random rnd = new Random();

    }
}
