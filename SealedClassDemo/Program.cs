
using System;

namespace SealedClassDemo
{
    // Base Class
    class Payment
    {
        public virtual void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment: " + amount);
        }
    }

    // Sealed Derived Class
    sealed class CreditCardPayment : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Credit Card Payment");
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Payment Successful");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CreditCardPayment payment =
                new CreditCardPayment();

            payment.ProcessPayment(5000m);

            // Polymorphism also works
            Payment payment2 = new CreditCardPayment();

            payment2.ProcessPayment(2500m);
        }
    }
}
 