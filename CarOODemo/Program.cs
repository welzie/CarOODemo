using System;

namespace CarOODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: create different cars and "drive" them
            GasCar explorer = new GasCar("Ford", "Explorer", 20, 15);
            explorer.Drive(75);
            explorer.Drive(50);

            ElectricCar leaf = new ElectricCar("Nissan", "Leaf", 60, 3);
            leaf.Drive(200);
            leaf.Drive(15);
        }
    }
}
