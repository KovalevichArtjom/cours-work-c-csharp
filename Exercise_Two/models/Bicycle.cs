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

        public override string getStateObj()
        {
            return string.Format(
                "{0}\n{1}\n{2}: {3}",
                string.Format("Information about Object \"{0}\"", typeof(Bicycle).Name),
                base.getStateObj(),
                typeof(Bicycle.typesFrame).FullName,
                this.typeFrame
                );
        }

        public override void printStateObj()
        {
            base.printStateObj();
        }
    }
}
