using Exercise_Two.models;
using System;

namespace Exercise_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 50;

            Car car = new Car(4000, 180, 1996, 4, "Opel", Car.typesBody.Hatchback);
            Bicycle bicycle = new Bicycle(710, 80, 2019, 1, "Random", Bicycle.typesFrame.Rigid);
            Lorry lorry = new Lorry(10000, 160, 2010, 1, "Volvo", Lorry.typesBody.Special);

            File file = new File("text", "txt");
            file.create();

            Composite composite = new Composite();
            composite.addComponent(car);
            composite.addComponent(bicycle);
            composite.addComponent(lorry);

            composite.sort();
            composite.printStateObj();

            Console.ReadKey();
        }
    }
}
