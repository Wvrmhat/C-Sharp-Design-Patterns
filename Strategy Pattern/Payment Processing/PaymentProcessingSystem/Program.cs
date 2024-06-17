using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
        

            IPaymentStrategy creditcard = new CreditCardPayment("111");
            IPaymentStrategy paypal = new PayPalPayment("123");
            IPaymentStrategy bitcoin = new BitcoinPayment("111111");

            Console.WriteLine("Would like to pay with\n (1) Credit Card\n (2) Pay Pal\n (3) Bitcoin");
            Console.Write("Select payment method: ");
            choice = int.Parse(Console.ReadLine());

            PaymentProcessor payment = new PaymentProcessor(creditcard);
            payment.ProcessPayment(500);

            payment = new PaymentProcessor(paypal);
            payment.ProcessPayment(500);

            payment = new PaymentProcessor(bitcoin);
            payment.ProcessPayment(2);

            
            
            double pay;                                             // Currency converter
            Console.Write("Enter amount to pay: ");
            pay = int.Parse(Console.ReadLine());
            ICurrency amount = new DollarCurrency(pay);
            amount.Currency(pay);


            amount = new BitcoinCurrency(pay);
            amount.Currency(pay);

            Console.ReadLine();





        }
    }
}
