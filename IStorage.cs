namespace AKavalevich
{
    interface IStorage
    {
        Product this[int index]
        {
            get;
            set;
        }

        public Product getProduct(int index);
        public bool sortByNProduct();
        public bool sortByAmount();
        public bool sortByCost();
        public void printSotrage();
    }
}
