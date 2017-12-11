using System;
using System.Collections.Generic;
using System.Text;

namespace CarOODemo
{
    public class CarMpgComparer : IComparer<ICar>
    {
        public int Compare(ICar x, ICar y)
        {
            return x.GetMilesPerGallon().CompareTo(y.GetMilesPerGallon());
        }
    }
}
