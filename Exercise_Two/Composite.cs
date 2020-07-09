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
            string description = "Sorting of objects by \"Cost\".";

            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.SetCursorPosition(
                (int)((Console.WindowWidth / 2) - (description.Length / 2)),
                Console.CursorTop
                );
            Console.WriteLine(description);
            Console.WriteLine(new string('-', Console.WindowWidth));

            this.components.Sort(
                (IVehicle x, IVehicle y) => (int)x.Cost - (int)y.Cost
            );
        }

        public void printStateObj()
        {
            foreach (IVehicle obj in this.components)
            {
                if (this.components.IndexOf(obj) != 0) Console.Write("\n\n");
                
                obj.printStateObj();
            }
        }

        public string getStateObj()
        {
            string content = "";

            foreach (IVehicle obj in this.components)
            {
                if (this.components.IndexOf(obj) != 0) content += "\n\n";

                content = string.Concat(content, obj.getStateObj());
            }

            return content;
        }
    }
}
