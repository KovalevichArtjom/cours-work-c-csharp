using System;
using System.Globalization;

namespace Exercise_Two
{
    abstract class BaseVehicle : IVehicle
    {
        private readonly CultureInfo BY = CultureInfo.GetCultureInfo("be-BY");
        public static int HEADER_POSITION;
        public decimal Cost { get; set; }
        private int mSpeed { get; set; }
        private int yearManufacture { get; set; }
        private int nWheels { get; set; }
        private string Manufacturer { get; set; }

        protected BaseVehicle(
            decimal Cost,
            int mSpeed,
            int yearManufacture,
            int nWheels,
            string Manufacturer
            ) 
        {
            this.Cost               = Cost;
            this.mSpeed             = mSpeed;
            this.yearManufacture    = yearManufacture;
            this.nWheels            = nWheels;
            this.Manufacturer       = Manufacturer;
        }

        public virtual string getStateObj()
        {
            return string.Format(
                            "base.Cost: {0}\nbase.mSpeed: {1}\nbase.yearManufacture: {2}\nbase.nWheels: {3}\nbase.Manufacturer: {4}",
                            string.Format(this.BY, "{0:C}", this.Cost),
                            this.mSpeed,
                            this.yearManufacture,
                            this.nWheels,
                            this.Manufacturer
                            );
        }

        public virtual void printStateObj()
        {
            Console.SetCursorPosition(BaseVehicle.HEADER_POSITION, Console.CursorTop);
            Console.WriteLine(this.getStateObj());
        }
    }
}
