using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // INTERFACE -- Contract : Means that if you inherit from interface, youi must implement certain methods to find inside the interface 

    // Nothing in an interface but ABSTRACT METHODS 

    // INTERFACE commonly have names that are ADJECTIVES and start with capital I
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }

        // Differnet abstract methods
        void Move();
        void Stop();
    }
}
