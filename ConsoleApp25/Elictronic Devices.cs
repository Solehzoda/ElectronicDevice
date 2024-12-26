using System;

namespace HomeDevices
{
    public class ElectronicDevice
    {
        private string brand;
        protected int batteryLevel;
        private bool isOn;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Batterylevel
        {
            get { return batteryLevel; }
            set
            {
                if (value > 100)
                    batteryLevel = 100;
                else if (value < 0)
                    batteryLevel = 0;
                else
                    batteryLevel = value;
            }
        }

        public bool IsOn
        {
            get { return isOn; }
            set { isOn = value; }
        }

        public void TurnOn()
        {
            if (!isOn)
            {
                isOn = true;
                Console.WriteLine($"{Brand} is now ON.");
            }
            else
            {
                Console.WriteLine($"{Brand} is already ON.");
            }
        }

        public void TurnOff()
        {
            if (isOn)
            {
                isOn = false;
                Console.WriteLine($"{Brand} is now OFF.");
            }
            else
            {
                Console.WriteLine($"{Brand} is already OFF.");
            }
        }

        public void Charge(int amount)
        {
            Batterylevel += amount;
            Console.WriteLine($"{Brand} charged to {Batterylevel}%.");
        }
    }
}