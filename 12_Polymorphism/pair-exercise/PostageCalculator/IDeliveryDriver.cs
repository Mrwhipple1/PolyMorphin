using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
    public interface IDeliveryDriver
    {
        double CalculateRate(int distance, double weight); // making set of requirements for other classes
        string Name { get;  }

    }
}
