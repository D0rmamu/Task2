using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Namber4
{
    public class Invoice
    {
        public double nds = 0.2;
        public Invoice(int account, int customer, string provider)
        {

        }

        public Invoice(int account, int customer, string provider, string article, int quantity) : this(account, customer, provider)
        {

        }

        private int account;

        public int Account
        {
            get { return account; }
            set { account = value; }
        }

        private int customer;

        public int Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private string provider;

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        private string article;

        public string Article
        {
            get { return article; }
            set { article = value; }
        }
        private int quantity;



        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public void Nds()
        {
            double result = account * nds;
            double x = account - result;
            Console.WriteLine(x);
        }

        public void Vaib()
        {
            string c = "1";
            string b = "2";
            Console.WriteLine("Выберите цену с налогом или без:");
            Console.WriteLine("1)notnds");
            Console.WriteLine("2)nds");
            string v = Console.ReadLine();
            if (v == b)
            {
                Nds();

            }
            if (v == c)
            {
                Console.WriteLine(account);
            }
        }
    }
}
