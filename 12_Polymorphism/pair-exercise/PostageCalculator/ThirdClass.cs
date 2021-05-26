using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
    public class ThirdClass : IDeliveryDriver
    {

        public ThirdClass(int distance, double weight)  // Constructor mkaes them available
        {


        }

        public  double CalculateRate(int distance, double weight)
        {
            if (weight <= 2)
            {
                return distance * .002;
            }

            else if (weight <= 8)
            {
                return distance * .0022;
            }
            else if (weight <= 15)
            {

                return distance * .0024;
            }
            else if (weight <= 48)
            {
                return distance * .015;
            }
            else if (weight <= 128)
            {

                return distance * .016;
            }
            else
            {
                return distance * .017;
            }
        }
        public string Name { get; } = "Postal Service (3rd Class) ";
    }
}
