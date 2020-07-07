﻿using System;

namespace Exercise_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 50;

            Car car = new Car(4000, 180, 1996, 4, "Opel", Car.typesBody.Hatchback);
            car.printStateObj();

            Bicycle bicycle = new Bicycle(710, 80, 2019, 1, "Random", Bicycle.typesFrame.Rigid);
            bicycle.printStateObj();


            Console.ReadKey();
        }
    }
}
