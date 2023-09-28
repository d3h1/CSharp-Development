using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_OOP
{
    class Television : IElectronicDevice
    {
        public int Volume {  get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolDown()
        {
            if (Volume != 0) Volume --;
            Console.WriteLine($"The TV volume is at {Volume}");
        }

        public void VolUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The TV volume is at {Volume}");
        }
    }
}
