//#define Debug
using System;

namespace AKavalevich
{
    class Application
    {
        private int cProducts;
        //properties of the product
        private string nProd;
        private int amountProd;
        private decimal costProd;

        private int indexProd;

        private const int COUNT_DASH = 50;
        private const char ELEMENT_CHAR = '-';
        private const char ELEMENT_ERROR = '#';

        private Storage storage;
        private Product product;

        public static void outputChar(char element = ELEMENT_CHAR, int count = COUNT_DASH)
        {
            Console.WriteLine(new String(element, count));
        }

        public void createStorage()
        {
            
            outputChar();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.Write(Message.ENTER_CREATE_STORAGE_TXT);
#if Debug
            this.cProducts = 5;
#else
            while (!int.TryParse(Console.ReadLine(), out this.cProducts) || isSign(this.cProducts))
            {
                outputChar(ELEMENT_ERROR);
                Console.WriteLine(Message.ERROR_TXT, Message.ERROR_CREATE_STORAGE_TXT);
                outputChar(ELEMENT_ERROR);

                Console.SetCursorPosition(15, Console.CursorTop);
                Console.Write(Message.ENTER_CREATE_STORAGE_TXT);
            }
#endif

            this.storage = new Storage();

            while (this.storage.getCount() < this.cProducts)
            {
                outputChar();
                Console.WriteLine("Index current Product => {0}", this.storage.getCount());
                this.storage.addProduct(this.createProduct());
                Console.Clear();
            }

            outputChar();
            this.storage.printSotrage();
            outputChar();

            Console.WriteLine("Press any key to view functionality...");
            Console.ReadKey();
        }
        private Product createProduct()
        {   
#if Debug            

            this.amountProd = (new Random()).Next(1, 20);
            Console.Write(string.Format("{0}{1}", Message.ENTER_COST_TXT, this.amountProd));

            this.nProd = string.Format("{0}{1}-{2}", (char)(new Random()).Next('a', 'z'), "ord", this.amountProd);

            Console.Write(string.Format("{0}{1}", Message.ENTER_AMOUNT_TXT, this.nProd));

            this.costProd = (new Random()).Next(1000, 4000);
            Console.Write(string.Format("{0}{1}", Message.ENTER_COST_TXT, this.costProd));

#else
            Console.Write(Message.ENTER_NAME_PRODUCT_TXT);

            this.nProd = Console.ReadLine();

            while (string.IsNullOrEmpty(this.nProd))
            {
                outputChar(ELEMENT_ERROR);
                Console.WriteLine(Message.ERROR_TXT, Message.ERROR_NAME_PRODUCT_TXT);
                outputChar(ELEMENT_ERROR);

                Console.Write(Message.ENTER_NAME_PRODUCT_TXT);

                this.nProd = Console.ReadLine();
            }

            Console.Write(Message.ENTER_AMOUNT_TXT);

            while (!int.TryParse(Console.ReadLine(), out this.amountProd) || isSign(this.amountProd))
            {
                outputChar(ELEMENT_ERROR);
                Console.WriteLine(Message.ERROR_TXT, Message.ERROR_AMOUNT_TXT);
                outputChar(ELEMENT_ERROR);

                Console.Write(Message.ENTER_AMOUNT_TXT);
            }

            Console.Write(Message.ENTER_COST_TXT);

            while (!decimal.TryParse(Console.ReadLine(), out this.costProd) || isSign((int) this.costProd))
            {
                outputChar(ELEMENT_ERROR);
                Console.WriteLine(Message.ERROR_TXT, Message.ERROR_COST_TXT);
                outputChar(ELEMENT_ERROR);

                Console.Write(Message.ENTER_COST_TXT);
            }
#endif

            Product product = new Product(this.nProd, this.amountProd, this.costProd);

            return product;
        }

        public void findProductByIndex()
        {
            Console.Clear();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.WriteLine("Find Product by index");
            outputChar();

#if Debug
            this.indexProd = 0;
#else
            Console.Write(Message.ENTER_INDEX_PRODUCT_TXT);

            while (
                !int.TryParse(Console.ReadLine(), out this.indexProd) 
                || isSign(this.indexProd)
                || storage.getCount() <= this.indexProd
                )
            {
                outputChar(ELEMENT_ERROR);
                Console.WriteLine(Message.ERROR_TXT, Message.ERROR_INDEX_PRODUCT_TXT);
                outputChar(ELEMENT_ERROR);

                outputChar();
                Console.Write(Message.ENTER_INDEX_PRODUCT_TXT);
            }
#endif
            this.product = this.storage[this.indexProd];

            Console.SetCursorPosition(3, Console.CursorTop);
            Console.WriteLine("Output information about Product by index[{0}]", this.indexProd);
            outputChar();

            Console.WriteLine("Name of Product => {0}", this.product.getNProduct());
            Console.WriteLine("Amount => {0}", this.product.getAmount());
            Console.WriteLine("Cost => {0}", this.product.getCost());
            outputChar();

            Console.WriteLine(Message.PRESS_TO_KEY);
            Console.ReadKey();
        }

        public void findProductByName()
        {
            Console.Clear();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.WriteLine("Find Product by Name");
            outputChar();

#if Debug == false
            Console.Write(Message.FIND_ENTER_NAME_TXT);
            
            this.product = null;


            while (this.product == null)
            {

                this.nProd = Console.ReadLine();

                while (string.IsNullOrEmpty(this.nProd))
                {
                    outputChar(ELEMENT_ERROR);
                    Console.WriteLine(Message.ERROR_TXT, Message.FIND_ERROR_NAME_TXT);
                    outputChar(ELEMENT_ERROR);

                    Console.Write(Message.FIND_ENTER_NAME_TXT);

                    this.nProd = Console.ReadLine();
                }

                this.product = this.storage.getProductByName(this.nProd);

                if (this.product == null) {

                    outputChar(ELEMENT_ERROR);
                    Console.WriteLine("Product with Name [{0}] not found.", this.nProd);
                    Console.WriteLine("Enter other Name of Product...");
                    outputChar(ELEMENT_ERROR);

                    Console.Write(Message.FIND_ENTER_NAME_TXT);
                }
            }
#endif
            Console.WriteLine("Output information about Product with Name[{0}]", this.product.getNProduct());
            outputChar();

            Console.WriteLine("Name of Product => {0}", this.product.getNProduct());
            Console.WriteLine("Amount => {0}", this.product.getAmount());
            Console.WriteLine("Cost => {0}", this.product.getCost());
            outputChar();

            Console.WriteLine(Message.PRESS_TO_KEY);
            Console.ReadKey();
        }

        public void sortByName()
        {
            Console.Clear();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.WriteLine("Sorting Products by Name");

            this.storage.sortByNProduct();

            outputChar();
            this.storage.printSotrage();
            outputChar();

            Console.WriteLine(Message.PRESS_TO_KEY);
            Console.ReadKey();

        }

        public void sortByAmount() 
        {
            outputChar();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.WriteLine("Sorting Products by Amount");

            this.storage.sortByAmount();

            outputChar();
            this.storage.printSotrage();
            outputChar();

            Console.WriteLine(Message.PRESS_TO_KEY);
            Console.ReadKey();

        }

        public void sortByCost()
        {
            outputChar();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.WriteLine("Sorting Products by Cost");

            this.storage.sortByCost();

            outputChar();
            this.storage.printSotrage();
            outputChar();

            Console.WriteLine(Message.PRESS_TO_KEY);
            Console.ReadKey();

        }

        private bool isSign(int number)
        {
            return Math.Sign(number) < 0 ? true : false;
        }

    }
}
