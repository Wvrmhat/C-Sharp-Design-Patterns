using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class BitcoinPayment : IPaymentStrategy
    {
        IPaymentStrategy bitcoin;
        private string wallet;

        public BitcoinPayment(string wallet)
        {
            this.bitcoin = bitcoin;
            this.wallet = wallet;
        }

        public void Pay()
        {
            Console.WriteLine("Using bitcoin ");
        }
    }
}
