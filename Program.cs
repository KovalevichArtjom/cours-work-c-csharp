using System;

namespace AKavalevich
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 50;
            Application app = new Application();

            app.createStorage();
            app.functionalityStorage();
            Console.ReadKey();
        }
    }
}
