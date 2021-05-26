using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator
{
    class Truck : IVehicle
    {
        public int NumberOfAxles { get; }
        public Truck(int numberOfAxels)
        {
            NumberOfAxles = numberOfAxels;
        }

        public double CalculateToll(int distance)
        {
            double toll = 0;
            if (NumberOfAxles == 4)
            {
                toll = 0.04 * distance;
            }
            else if (NumberOfAxles == 6)
            {
                toll = 0.045 * distance;
            }
            else
            {
                toll = .048 * distance;
            }

            return toll;

        }

    }
}
