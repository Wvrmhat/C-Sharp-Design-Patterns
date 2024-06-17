using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class DollarCurrency : ICurrency
    {
        ICurrency dollar;
        double pay;

        public DollarCurrency(double dollar)
        {
            this.pay = dollar;
        }

        public void Currency(double amount)
        {
            double rate = 18.68;
         //   double value = 1;
         //   Console.WriteLine("Enter your amount: ");
          //  value = int.Parse(Console.ReadLine());

            double total = amount * rate;


            Console.WriteLine($"{total} paid in dollars"); 
        }
    }
}
