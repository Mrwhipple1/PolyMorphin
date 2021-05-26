using System;
using System.Collections.Generic;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            Random rand = new Random();
            int randomMiles = rand.Next(10, 241);  // how to generate random number between (10-241)
            int randomMiles2 = rand.Next(10, 241);
            int randomMiles3 = rand.Next(10, 241);  // we created random number for each item in our list
            int randomMiles4 = rand.Next(10, 241);
            int randomMiles5 = rand.Next(10, 241);
            int randomMiles6 = rand.Next(10, 241);

            List<IVehicle> vehicles = new List<IVehicle>();

            Car car = new Car(false); // creates our car without a trailer.  from class
            vehicles.Add(car);           // gets car into our list

            Car carWithTrailer = new Car(true);   // creates our car without a trailer.
            vehicles.Add(carWithTrailer);

            Tank tank = new Tank();  // Tank took nothing in becasue toll 0
            vehicles.Add(tank);

            Truck truck4 = new Truck(4);  // takes in integer number of axels
            vehicles.Add(truck4);

            Truck truck6 = new Truck(6);
            vehicles.Add(truck6);

            Truck truck8 = new Truck(8);
            vehicles.Add(truck8);

            Console.WriteLine("Vehicle     distance traveled     toll$");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Car              " + randomMiles + "                      " + car.CalculateToll(randomMiles));
            Console.WriteLine("Car with Trailer " + randomMiles2 + "                     " + carWithTrailer.CalculateToll(randomMiles2));
            Console.WriteLine("Tank             " + randomMiles3 + "                     " + tank.CalculateToll(randomMiles3));
            Console.WriteLine("truck4           " + randomMiles4 + "                     " + truck4.CalculateToll(randomMiles4));
            Console.WriteLine("truck6           " + randomMiles5 + "                     " + truck6.CalculateToll(randomMiles5));
            Console.WriteLine("truck8           " + randomMiles6 + "                     " + truck8.CalculateToll(randomMiles6));
            Console.WriteLine();
            Console.WriteLine("Total miles traveled: " + (randomMiles + randomMiles2 + randomMiles3 + randomMiles4 + randomMiles5 + randomMiles6));
            Console.WriteLine("Total Tollbooth Revenue: " + (car.CalculateToll(randomMiles) + carWithTrailer.CalculateToll(randomMiles2)
                             + tank.CalculateToll(randomMiles3) + truck4.CalculateToll(randomMiles4) + truck6.CalculateToll(randomMiles5) + truck8.CalculateToll(randomMiles6)));
        }

    }
}






