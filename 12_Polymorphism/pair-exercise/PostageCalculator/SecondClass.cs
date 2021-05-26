using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
   public class SecondClass : IDeliveryDriver
    {
        public SecondClass(int distance, double weight)   // Constructor mkaes them available
        {


        }

        public  double CalculateRate(int distance, double weight)
        {
            if (weight <= 2)
            {
                return distance * .0035;
            }

            else if (weight <= 8)
            {
                return distance * .004;
            }
            else if (weight <= 15)
            {

                return distance * .0047;
            }
            else if (weight <= 48)
            {
                return distance * .0195;
            }
            else if (weight <= 128)
            {

                return distance * .045;
            }
            else
            {
                return distance * .05;
            }
        }

        public string Name { get; } = "Postal Service (2nd Class) ";
    }
}

    

