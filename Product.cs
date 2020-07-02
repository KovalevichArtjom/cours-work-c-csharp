namespace AKavalevich
{
    class Product : IProduct
    {
        private string nProduct { get; set; }
        private int amount { get; set; }
        private decimal cost { get; set; }

        public Product(string nProduct, int amount, decimal cost)
        {
            this.nProduct   = nProduct;
            this.amount     = amount;
            this.cost       = cost;
        }
        public string getNProduct()
        {
            return this.nProduct;
        }
        public int getAmount()
        {
            return this.amount;
        }
        public decimal getCost()
        {
            return this.cost;
        }
    }
}
