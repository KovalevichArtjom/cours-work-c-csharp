using System;

namespace Exercise_Two.models
{
    class Lorry : BaseVehicle
    {
        public enum typesBody
        {
            Open, Close, Special
        }

        private readonly typesBody typeBody;

        public Lorry(
            decimal Cost,
            int mSpeed,
            int yearManufacture,
            int nWheels,
            string Manufacturer,
            typesBody typeBody
            ) : base(
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
                string.Format("Information about Object \"{0}\"", typeof(Lorry).Name),
                base.getStateObj(),
                typeof(Lorry.typesBody).FullName,
                this.typeBody
                );
        }

        public override void printStateObj()
        {
            base.printStateObj();
        }
    }
}
