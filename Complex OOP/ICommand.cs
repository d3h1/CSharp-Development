using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_OOP
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
