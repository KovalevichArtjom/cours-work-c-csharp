using System;

namespace AKavalevich
{
    interface IProduct : IComparable<Product>
    {
        private string nProduct { 
            get {
                return this.nProduct;
            }
            set {
                this.nProduct = value;
            } 
        }
        private int amount {
            get {
                return this.amount;
            }
            set {
                this.amount = value;
            }
        }
        private decimal cost {
            get {
                return this.cost;
            }
            set {
                this.cost = value;
            }
        }

        string getNProduct();
        int getAmount();
        decimal getCost();
        public new int CompareTo(Product obj);
    }
}
