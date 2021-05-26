﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
   public class SPU2DAY : IDeliveryDriver
    {
        public int Distance { get; }        // properties are set by constructor below 
        public double Weight { get; }

        public SPU2DAY(int distance, double weight) // constructor that will get inherited 
        {
            Distance = distance;
            Weight = weight;
        }

        public double CalculateRate(int distance, double weight)
        {
            weight = weight / 16;
            return (weight * .05) * distance;
        }
        public string Name { get; } = "SPU (2-Day Business) ";

    }
}
