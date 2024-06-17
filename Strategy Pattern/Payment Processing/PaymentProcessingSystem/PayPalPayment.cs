using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class PayPalPayment : IPaymentStrategy
    {
        IPaymentStrategy eft;
        private string pin;

        public PayPalPayment(string pin)
        {
            this.eft = eft;
            this.pin = pin;

        

        }

        public void Pay()
        {
            Console.WriteLine("Using eft");
        }
    }
}
