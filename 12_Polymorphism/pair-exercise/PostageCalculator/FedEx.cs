using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
    public class FedEx : IDeliveryDriver
    {
        public int Distance { get; }        // properties are set by constructor below 
        public double Weight { get; }

        public FedEx(int distance, double weight) // constructor that will get inherited 
        {
            Distance = distance;
            Weight = weight;
        }

        public double CalculateRate(int distance, double weight)
        {
            if( distance > 500 && weight > 48)
            {
                return 28;

            }
            else if(distance > 500)
            {
                return 25;
            }
            else if(weight > 48)
            {
                return 23;
            }
            else
            {
                return 20;
            }
        }

        public string Name { get; } = "FedEx  ";
    }
}
