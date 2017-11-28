using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public class ElectricCar : Car
    {
        public int BatteryKwhSize { get; private set; }
        public double BatteryLevel { get; private set; }
        public double MilesPerKwh { get; private set; }

        public ElectricCar(string make, string model, int batteryKwhSize, double milesPerKwh) 
            : base(make, model)
        {
            this.BatteryKwhSize = batteryKwhSize;
            this.BatteryLevel = batteryKwhSize;
            this.MilesPerKwh = milesPerKwh;
        }

        public override void Drive(int miles)
        {
            //adjust fuel based on mmp
            //write out distance traveled and fuel remaining
            double maxDistance = this.MilesPerKwh * this.BatteryLevel;
            double distanceTraveled = miles;
            if (miles > maxDistance)
            {
                distanceTraveled = maxDistance;
            }
            double kwhUsed = distanceTraveled / this.MilesPerKwh;
            this.BatteryLevel = this.BatteryLevel - kwhUsed;
            var text = String.Format("Traveled {0} Miles, Kwh Used {1}, Kwh Remaining {2}", distanceTraveled, kwhUsed, this.BatteryLevel);
            Console.WriteLine(text);

        }
    }
}
