using System;
using System.Collections.Generic;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the weight of the package: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("(P)ounds or (O)unces?: ");
            string pOrO = Console.ReadLine();
            Console.Write("What distance will it be traveling?: ");
            int distance = int.Parse(Console.ReadLine());

            if (pOrO == "P")
            {
                weight = weight * 16;

            }

            List<IDeliveryDriver> deliveries = new List<IDeliveryDriver>();
            FirstClass firstClass = new FirstClass(distance, weight);   // object of type FirstClass 
            deliveries.Add(firstClass);   // added to list deliveries

            SecondClass secondClass = new SecondClass(distance, weight);   // object of type FirstClass 
            deliveries.Add(secondClass);

            ThirdClass thirdClass = new ThirdClass(distance, weight);   // object of type FirstClass 
            deliveries.Add(thirdClass);

            FedEx fedEx = new FedEx(distance, weight);
            deliveries.Add(fedEx);

            SPUNEXTDAY spuNextDay = new SPUNEXTDAY(distance, weight);
            deliveries.Add(spuNextDay);

            SPU2DAY spu2Day = new SPU2DAY(distance, weight);
            deliveries.Add(spu2Day);

            SPU4DAY spu4Day = new SPU4DAY(distance, weight);
            deliveries.Add(spu4Day);


            Console.WriteLine();  // leave a line blank 
            Console.WriteLine("Delivery Method                        $cost");
            Console.WriteLine("--------------------------------------------");


            foreach (IDeliveryDriver delivery in deliveries)
            {
                Console.WriteLine(delivery.Name + " $" + delivery.CalculateRate(distance, weight));    // attempted string.Format could not figure that one out

            }

           


        //    Console.WriteLine();  // leave a line blank 
        //    Console.WriteLine("Delivery Method                        $cost");
        //    Console.WriteLine("--------------------------------------------");
        //    Console.WriteLine("Postal Service (1st Class)             $" + (firstClass.CalculateRate(distance, weight)));
        //    Console.WriteLine("Postal Service (2nd Class)             $" + (secondClass.CalculateRate(distance, weight)));
        //    Console.WriteLine("Postal Service (3rd Class)             $" + (thirdClass.CalculateRate(distance, weight)));
        //    Console.WriteLine("FedEx                                  $" + (fedEx.CalculateRate(distance, weight)));
        //    Console.WriteLine("SPU (4-Day Ground)                     $" + (spu4Day.CalculateRate(distance, weight)));
        //    Console.WriteLine("SPU (2-Day Ground)                     $" + (spu2Day.CalculateRate(distance, weight)));
        //    Console.WriteLine("SPU (Next Day)                         $" + (spuNextDay.CalculateRate(distance, weight)));
        }


    }
}

