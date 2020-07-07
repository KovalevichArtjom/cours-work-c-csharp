using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Exercise_Two
{
    abstract class ABaseVehicle : IComparable<ABaseVehicle>
    {
        private readonly CultureInfo BY = CultureInfo.GetCultureInfo("be-BY");

        public readonly decimal Cost;
        public readonly int mSpeed;
        public readonly int yearManufacture;
        public readonly int nWheels;
        public readonly string Manufacturer;

        protected ABaseVehicle(
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

        protected virtual string getStateObj()
        {
            return string.Format(
                            "base.Cost: {0}\nbase.mSpeed: {1}\nbase.yearManufacture: {2}\nbase.nWheels: {3}\nbase.Manufacturer: {4}",
                            string.Format(this.BY, "{0:C}", this.Cost),
                            this.mSpeed,
                            this.yearManufacture,
                            this.nWheels,
                            this.Manufacturer
                            ); ;
        }

        public virtual void printStateObj()
        {
            Console.WriteLine(this.getStateObj());
        }

        public abstract int CompareTo(ABaseVehicle other);
    }
}
