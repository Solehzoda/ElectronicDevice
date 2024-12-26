using System;

namespace HomeDevices
{
    public class PC : ElectronicDevice
    {
        public PC(string brand, int batteryLevel)
        {
            Brand = brand;
            Batterylevel = batteryLevel;
            IsOn = false;
        }

        public void OpenSettings(string appName)
        {
            if (IsOn && Batterylevel > 0)
            {
                Console.WriteLine($"{Brand} is opening {appName}...");
                Batterylevel -= 10;

                if (Batterylevel < 0)
                    Batterylevel = 0;
            }
            else
            {
                Console.WriteLine($"Cannot open {appName}. {Brand} is OFF or has no charge.");
            }
        }
    }
}