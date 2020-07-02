#define Debug
using System;

namespace AKavalevich
{
    class Application
    {
        protected int cProducts;

        protected string nProd;
        protected int amountProd;
        protected decimal costProd;

        protected const int COUNT_DASH = 50;
        protected const char ELEMENT_CHAR = '-';
        protected const char ELEMENT_ERROR = '#';

        private Storage storage;
        /*Вынести в отдельный словарь сонстант*/
        private readonly string ERROR_TXT = "\aERROR: {0}.\nRepeat Entry...";

        public static void outputDash(char element = ELEMENT_CHAR, int count = COUNT_DASH)
        {
            Console.WriteLine(new String(element, count));
        }

        public void createStorage()
        {
            string ERROR_TXT = "Number expected";
            string ENTER_TXT = "Enter count products:";
            
            outputDash();

            Console.SetCursorPosition(15, Console.CursorTop);
            Console.Write(ENTER_TXT);
#if Debug
            this.cProducts = 2;
#else
            while (!int.TryParse(Console.ReadLine(), out this.cProducts) || isSign(this.cProducts))
            {
                outputDash(ELEMENT_ERROR);
                Console.WriteLine(this.ERROR_TXT, ERROR_TXT);
                outputDash(ELEMENT_ERROR);

                Console.SetCursorPosition(15, Console.CursorTop);
                Console.Write(ENTER_TXT);
            }
#endif

            this.storage = new Storage();

            while (this.storage.getCount() < this.cProducts)
            {
                outputDash();
                Console.WriteLine("Index current Product => {0}", this.storage.getCount());
                this.storage.addProduct(this.createProduct());
                Console.Clear();
            }

            outputDash();
            this.storage.printSotrage();
            outputDash();
            Console.WriteLine("Press any key to view functionality...");
            Console.ReadKey();
        }
        private Product createProduct()
        {
            string ENTER_NAME_TXT = "Enter Name Of Product: ";
            string ERROR_NAME_TXT = "Name of Product not set";

            string ENTER_AMOUNT_TXT = "Enter Amount: ";
            string ERROR_AMOUNT_TXT = "Amount not set";
            
            string ENTER_COST_TXT = "Enter Cost: ";
            string ERROR_COST_TXT = "Cost not set";

            Console.Write(ENTER_NAME_TXT);
#if Debug            

            this.amountProd = (new Random()).Next(1, 10);
            Console.Write(string.Format("{0}{1}", ENTER_COST_TXT, this.amountProd));

            this.nProd = string.Format("{0}-{1}", "Ford", this.amountProd);

            Console.Write(string.Format("{0}{1}", ENTER_AMOUNT_TXT, this.nProd));

            this.costProd = (new Random()).Next(1000, 4000);
            Console.Write(string.Format("{0}{1}", ENTER_COST_TXT, this.costProd));

#else
            this.nProd = Console.ReadLine();

            while (string.IsNullOrEmpty(this.nProd))
            {
                outputDash(ELEMENT_ERROR);
                Console.WriteLine(this.ERROR_TXT, ERROR_NAME_TXT);
                outputDash(ELEMENT_ERROR);

                Console.Write(ENTER_NAME_TXT);

                this.nProd = Console.ReadLine();
            }

            Console.Write(ENTER_AMOUNT_TXT);

            while (!int.TryParse(Console.ReadLine(), out this.amountProd) || isSign((int)this.amountProd))
            {
                outputDash(ELEMENT_ERROR);
                Console.WriteLine(this.ERROR_TXT, ERROR_AMOUNT_TXT);
                outputDash(ELEMENT_ERROR);

                Console.Write(ENTER_AMOUNT_TXT);
            }

            Console.Write(ENTER_COST_TXT);

            while (!decimal.TryParse(Console.ReadLine(), out this.costProd) || isSign((int) this.costProd))
            {
                outputDash(ELEMENT_ERROR);
                Console.WriteLine(this.ERROR_TXT, ERROR_COST_TXT);
                outputDash(ELEMENT_ERROR);

                Console.Write(ENTER_COST_TXT);
            }
#endif

            Product product = new Product(this.nProd, this.amountProd, this.costProd);

            return product;
        }
        public void functionalityStorage()
        {
            Console.Clear();

            outputDash();
            Console.SetCursorPosition(10, Console.CursorTop);
            Console.WriteLine("Output information about Product by index");

        }
        private bool isSign(int number)
        {
            return Math.Sign(number) < 0 ? true : false;
        }

    }
}
