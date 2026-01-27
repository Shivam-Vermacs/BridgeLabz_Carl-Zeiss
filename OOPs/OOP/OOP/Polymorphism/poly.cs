using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    class poly
    {
        protected double Amount;

        public poly(double amount)
        {
            Amount = amount;
        }
        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Process Payment of {Amount}");
        }
        public virtual string GetPaymentDetails()
        {
            return $"Payment amount {Amount}";
        }
    }
    class CardPayment : poly
    {
        private string CardNumber;
        private string CardHolderName;

        public CardPayment(double amount ,string cardholdername) : base(Amount)
        {
           
            CardHolderName = cardholdername;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing Card Payment of {Amount} ");
            Console.WriteLine($"Payment of {Amount} successful via Card");
        }
        public override string GetPaymentDetails()
        {
            return $"Card HolderName : {CardHolderName} , Amount : {Amount}";
        }

    }
}
