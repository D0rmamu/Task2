using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Namber2
{
        public class Converter
        {

            double itog1;
            double itog2;
            public Converter(double itog1, double itog2, double btc, double eth, double bnb, double RB)
            {

            }
        private double _rb;

        public double RB
        {
            get { return _rb; }
            set { _rb = value; }
        }

        private double btc;

            public double Btc
            {
                get { return btc; }
                set { btc = value; }
            }
            private double eth;

            public double Eth
            {
                get { return eth; }
                set { eth = value; }
            }

            private double bnb;

            public double Bnb
            {
                get { return bnb; }
                set { bnb = value; }
            }

            public void Convert1()
            {

                itog1 = RB * btc;
                itog2 = btc / RB;

                Console.WriteLine($"Из RB в btc - {itog1}");;
                Console.WriteLine($"Из btc в RB - {itog2}");


            }
            public void Convert2()
            {
                itog1 = RB * eth;
                itog2 = eth / RB;

            Console.WriteLine($"Из RB в eth - {itog1}");
            Console.WriteLine($"Из eth в RB - {itog2}");
        }
            public void Convert3()
            {
                itog1 = RB * bnb;
                itog2 = bnb / RB;

            Console.WriteLine($"Из RB в bnb - {itog1}");
            Console.WriteLine($"Из bnb в RB - {itog2}");

        }



        }
    
}