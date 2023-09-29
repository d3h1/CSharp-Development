using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_OOP
{
    internal class VolumeButton : ICommand
    {
        IElectronicDevice device;

        public VolumeButton(IElectronicDevice device)
        {
            this.device = device;
        } 

        public void Execute()
        {
            device.VolUp();
        }

        public void Undo()
        {
            device.VolDown();
        }
    }
}
