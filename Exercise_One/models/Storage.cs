using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        public Product getProductByName(string nProduct)
        {
            return (Product)this.storage.Find(prod => prod.getNProduct() == nProduct);
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
            this.storage.Sort((Product x, Product y) =>
                (int)x.getCost() - (int)y.getCost()
            ); ;

            return true;
        }

        public bool sortByNProduct()
        {
            this.storage.Sort();

            return true;
        }

        public bool sortByAmount()
        {
            this.storage.Sort((Product x, Product y) =>
                x.getAmount() - y.getAmount()
            );

            return true;
        }
    }
}
