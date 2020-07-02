using System;
using System.Collections.Generic;
using System.Globalization;

namespace AKavalevich
{
    class Storage : IStorage
    {
        private List<Product> storage = new List<Product>();
        public Product this[int index] {
            get {
                return this.storage[index];
            }
            set {
                this.storage.Add(value);
            } 
        }

        protected readonly CultureInfo BY = CultureInfo.GetCultureInfo("be-BY");

        public Product getProduct(int index)
        {
            return this.storage[index];
        }

        public void addProduct(Product product) 
        {
            this.storage.Add(product);
        }

        public void printSotrage()
        {
            int countElements = this.storage.Count - 1;

            Console.WriteLine("Name of Product\tAmount\tCost");

            foreach (Product product in this.storage)
            {
                Console.WriteLine(
                    "{0, 10}\t{1, 3}\t{2}",
                    product.getNProduct(),
                    product.getAmount(),
                    String.Format(this.BY, "{0:C}", product.getCost())
                    );

                if (this.storage.LastIndexOf(product) != countElements) Console.WriteLine();
            }
        }

        public int getCount()
        {
            return this.storage.Count;
        }

        public bool sortByCost()
        {
            this.storage.Sort();

            return true;
        }

        public bool sortByNProduct()
        {
            throw new NotImplementedException();
        }

        public bool sortByAmount()
        {
            throw new NotImplementedException();
        }
    }
}
