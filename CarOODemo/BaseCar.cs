using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public abstract class BaseCar
    {
        public string Make { get; private set; }
        public string Model { get; private set; }

        public BaseCar(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
    }
}
