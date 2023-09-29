using Complex_OOP;
using System;

namespace ComplexOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Picking up the device
            IElectronicDevice TV = TVRemote.GetDevice();

            //Power Button
            PowerButton powBut = new PowerButton(TV);
            VolumeButton volBut = new VolumeButton(TV);

            // Executing power button
            powBut.Execute();
            powBut.Undo();
            powBut.Execute();
            powBut.Undo();

            // Executing volume button
            volBut.Execute();
            volBut.Execute();
            volBut.Execute();
            volBut.Undo();

        }
    }
}