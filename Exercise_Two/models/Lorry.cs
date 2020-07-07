using System;

namespace Exercise_Two.models
{
    class Lorry : ABaseVehicle
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

        protected override string getStateObj()
        {
            return string.Format("{0}\n{1}: {2}",
                base.getStateObj(),
                typeof(Lorry.typesBody).FullName,
                this.typeBody
                );
        }

        public override void printStateObj()
        {
            Console.WriteLine("Information about Object \"{0}\"\n", typeof(Lorry).Name);
            base.printStateObj();
        }

        public override int CompareTo(ABaseVehicle other)
        {
            if (other == null) return 1;

            return this.yearManufacture.CompareTo(other.yearManufacture);
        }
    }
}
