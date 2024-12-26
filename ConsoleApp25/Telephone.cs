using System;

namespace HomeDevices
{
    public class Telephone : ElectronicDevice
    {
        public Telephone(int batteryLevel, string brand)
        {
            Brand = brand;
            Batterylevel = batteryLevel;
            IsOn = false;
        }

        public void Call(string phoneNumber)
        {
            if (IsOn && Batterylevel > 0)
            {
                Console.WriteLine($"{Brand} is calling {phoneNumber}...");
                Batterylevel -= 5;

                if (Batterylevel < 0)
                    Batterylevel = 0;
            }
            else
            {
                Console.WriteLine($"Cannot call {phoneNumber}. {Brand} is OFF or has no charge.");
            }
        }
    }
}