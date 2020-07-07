namespace AKavalevich
{
    interface IStorage
    {
        Product this[int index]
        {
            get;
            set;
        }

        public Product getProductByName(string nProduct);
        public void addProduct(Product product);
        public bool sortByNProduct();
        public bool sortByAmount();
        public bool sortByCost();
        public void printSotrage();
    }
}
