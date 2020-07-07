using System;

namespace Exercise_Two
{
    class Car : ABaseVehicle
    {
        public enum typesBody
        {
            Sedan, Coupe, Hatchback, Minivan,
            Truck, StationWagon, Convertible, SUV
        }

        private readonly typesBody typeBody;

        public Car(
            decimal Cost,
            int mSpeed,
            int yearManufacture,
            int nWheels,
            string Manufacturer,
            typesBody typeBody
            ) : base (
            Cost,
            mSpeed,
            yearManufacture,
            nWheels,
            Manufacturer
                )
        { this.typeBody = typeBody; }

        protected override string getStateObj()
        {
            return string.Format("{0}\n{1}: {2}",
                base.getStateObj(),
                typeof(Car.typesBody).FullName,
                this.typeBody
                );
        }

        public override void printStateObj()
        {
            Console.WriteLine("Information about Object \"{0}\"\n", typeof(Car).Name);
            base.printStateObj();
        }
    }
}
