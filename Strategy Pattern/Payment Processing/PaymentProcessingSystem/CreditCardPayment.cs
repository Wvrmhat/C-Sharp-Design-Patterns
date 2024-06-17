using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class CreditCardPayment : IPaymentStrategy      // Concrete strategy
    {
        IPaymentStrategy card;
        private string CVV;

        public CreditCardPayment(string cvv)
        {
           // this.card = card;
            this.CVV = cvv;
        }

        public void Pay()
        {

            Console.WriteLine("Using credit card");
        }
    }
}
