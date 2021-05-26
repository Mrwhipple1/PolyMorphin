using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator
{
    class Car : IVehicle
    {
    public bool HasTrailer { get;  }  // property is in the Interface
       public Car(bool hasTrailer)  // constructor
        {
            HasTrailer = hasTrailer; // seting a read only property with the constructor
        }

        public double CalculateToll(int distance)  // method in class car but also method from IVehicle
        {
            double toll = 0;
            toll = distance * 0.020;

            if(HasTrailer)
            {
                toll = toll + 1;
                return toll;
            }
            else
            {
                return toll;
            }
        }

    }



}
