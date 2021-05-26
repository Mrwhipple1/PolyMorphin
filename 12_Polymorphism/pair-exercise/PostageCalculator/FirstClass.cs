using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
    public class FirstClass : IDeliveryDriver
    {
        public FirstClass(int distance, double weight)  // Constructor mkaes them available
        {


        }

        public  double CalculateRate(int distance, double weight)
        {
            if (weight <= 2)
            {
                return distance * .035;
            }

            else if (weight <= 8)
            {
                return distance * .04;
            }
            else if (weight <= 15)
            {

                return distance * .047;
            }
            else if (weight <= 48)
            {
                return distance * .195;
            }
            else if (weight <= 128)
            {

                return distance * .45;
            }
            else
            {
                return distance * .5;
            }
        }
        public string Name { get; } = "Postal Service (1st Class) ";
    }
}
