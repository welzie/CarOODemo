using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public class GasCar : BaseCar, ICar
    {
        public int GasTankSize { get; private set; }
        public double GasTankLevel { get; private set; }
        public double MilesPerGallon { get; private set; }

        public GasCar(string make, string model, int gasTankSize, double milesPerGallon) 
            : base(make, model)
        {
            this.GasTankSize = gasTankSize;
            this.GasTankLevel = gasTankSize;
            this.MilesPerGallon = milesPerGallon;
        }

        public void Drive(int miles)
        {
            //adjust fuel based on mmp
            //write out distance traveled and fuel remaining
            double maxDistance = this.MilesPerGallon * this.GasTankLevel;
            double distanceTraveled = miles;
            if (miles > maxDistance)
            {
                distanceTraveled = maxDistance;
            }
            double gallonsUsed = distanceTraveled / this.MilesPerGallon;
            this.GasTankLevel = this.GasTankLevel - gallonsUsed;
            var text = String.Format("Traveled {0} Miles, Gallons Used {1}, Gallons Remaining {2}", distanceTraveled, gallonsUsed, this.GasTankLevel);
            Console.WriteLine(text);

        }

        public void Start()
        {
            Console.WriteLine(String.Format("{0} - {1} started, gas engine running", this.Make, this.Model));
        }

        public double GetMilesPerGallon()
        {
            return this.MilesPerGallon;
        }
    }
}
