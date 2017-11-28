using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public abstract class Car
    {
        public string Make { get; private set; }
        public string Model { get; private set; }

        public Car(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        public abstract void Drive(int miles);

    }
}
