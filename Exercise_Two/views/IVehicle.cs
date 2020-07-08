using System;

namespace Exercise_Two
{
    interface IVehicle
    {
        public decimal Cost {
            get
            {
                return this.Cost;
            }
            set => this.Cost = value;
        }
        private string Manufacturer
        {
            get
            {
                return this.Manufacturer;
            }
            set => this.Manufacturer = value;
        }
        private int mSpeed {
            get
            {
                return this.mSpeed;
            }
            set => this.mSpeed = value;
        }
        private int yearManufacture {
            get 
            {
                return this.yearManufacture;
            }
            set => this.yearManufacture = value;
        }
        private int nWheels {
            get
            {
                return this.nWheels;
            }
            set => this.nWheels = value;
        }
        public void printStateObj();
    }
}
