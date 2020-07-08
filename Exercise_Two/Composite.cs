using System;
using System.Collections.Generic;

namespace Exercise_Two
{
    class Composite : IVehicle
    {
        private List<IVehicle> components = new List<IVehicle>();

        public void addComponent(IVehicle component)
        {
            this.components.Add(component);
        }

        public void removeComponent(IVehicle component)
        {
            this.components.Remove(component);
        }
        public void sort()
        {
            this.components.Sort(
                (IVehicle x, IVehicle y) => (int)x.Cost - (int)y.Cost
            );
        }
        public void printStateObj()
        {
            foreach (IVehicle obj in this.components)
            {
                obj.printStateObj();
            }
        }
    }
}
