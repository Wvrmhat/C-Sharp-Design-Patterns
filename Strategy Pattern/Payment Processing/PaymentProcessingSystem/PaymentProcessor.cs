using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class PaymentProcessor
    {
        private IPaymentStrategy payment;

        public PaymentProcessor(IPaymentStrategy payment)
        {
            this.payment = payment;

        }

        public void ProcessPayment(double amount)
        {
            payment.Pay();
        }
    }
}
