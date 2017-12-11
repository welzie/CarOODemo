using System;
using System.Collections.Generic;

namespace CarOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: create different cars and "drive" them
            GasCar explorer = new GasCar("Ford", "Explorer", 20, 15);
            ElectricCar leaf = new ElectricCar("Nissan", "Leaf", 60, 3);

            List<ICar> cars = new List<ICar>()
            {
                explorer,
                leaf,
                new GasCar("Ford", "Pinto", 10, 30)
            };

            cars.Sort(new CarMpgComparer());
            foreach (ICar car in cars)
            {
                car.Start();
                Console.WriteLine("MPG " + car.GetMilesPerGallon());
                car.Drive(75);
                car.Drive(50);
            }

        }
    }
}
