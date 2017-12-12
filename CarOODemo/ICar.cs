using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public interface ICar
    {
        void Drive(int miles);
        void Start();
        double GetMilesPerGallon();
    }
}
