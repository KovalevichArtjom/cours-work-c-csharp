using System;

namespace Exercise_Two
{
    class Bicycle : BaseVehicle
    {
        public enum typesFrame
        {
            Rigid, HardTail, FullSuspension, SoftTail
        }

        private readonly typesFrame typeFrame;

        public Bicycle(
            decimal Cost,
            int mSpeed,
            int yearManufacture,
            int nWheels,
            string Manufacturer,
            typesFrame typeFrame
            ) : base(
            Cost,
            mSpeed,
            yearManufacture,
            nWheels,
            Manufacturer
                )
        { this.typeFrame = typeFrame; }

        protected override string getStateObj()
        {
            return string.Format("{0}\n{1}: {2}",
                base.getStateObj(),
                typeof(Bicycle.typesFrame).FullName,
                this.typeFrame
                );
        }

        public override void printStateObj()
        {
            Console.WriteLine("\nInformation about Object \"{0}\"\n", typeof(Bicycle).Name);
            base.printStateObj();
        }
    }
}
