using System;

namespace HomeDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone telephone = new Telephone(100, "Samsung");
            PC pc = new PC("HP", 67);

            telephone.TurnOn();
            telephone.Call("+992 905520055");
            telephone.Charge(50);

            pc.TurnOn();
            pc.Charge(44);
            pc.OpenSettings("JetBrains Rider");
            pc.TurnOff();
        }
    }
}