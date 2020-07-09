using System;

namespace Exercise_Two
{
    class Car : BaseVehicle
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

        public override string getStateObj()
        {
            return string.Format(
                "{0}\n{1}\n{2}: {3}",
                string.Format("Information about Object \"{0}\"", typeof(Car).Name),
                base.getStateObj(),
                typeof(Car.typesBody).FullName,
                this.typeBody
                );
        }

        public override void printStateObj()
        {
            base.printStateObj();
        }
    }
}
