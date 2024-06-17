using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class BitcoinCurrency : ICurrency
    {
        ICurrency bitcoin;
        double pay;

        public BitcoinCurrency(double bitcoin)
        {
            this.pay = bitcoin;
        }

        public void Currency(double amount)
        {
            double rate = 1315716.47;

           // double value;
           // Console.WriteLine("Enter a value: ");
            //value = int.Parse(Console.ReadLine());

            double total = amount * rate;
            
            Console.WriteLine($"{total} paid in bitcoin");
        }
    }
}
