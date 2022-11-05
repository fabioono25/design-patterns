using System;
using design_patterns.GangOfFour.Structural.Strategy.Payment;

namespace design_patterns.GangOfFour.Behavioral.Strategy.Payment.Solution
{
    // Context: connect the Client with the Strategy interface
    public class PaymentService
    {
        private int cost;
        private readonly bool includeDelivery;

        private PaymentStrategy strategy;

        public void ProcessOrder(int cost)
        {
            this.cost = cost;
            strategy.CollectPaymentDetails();

            if (strategy.ValidatePaymentDetails())
                strategy.Pay(GetTotal());
        }

        public void SetStrategy(PaymentStrategy paymentStrategy)
        {
            strategy = paymentStrategy;
        }

        private int GetTotal() => includeDelivery ? cost + 10 : cost;
    }

    // Strategy interface: common to all concrete strategies (flexibility)
    public interface PaymentStrategy
    {
        void CollectPaymentDetails();
        bool ValidatePaymentDetails();
        void Pay(int amount);
    }

    // Concrete Strategy: implement different variations of the algorithm the context uses.
    public class PaymentByCreditCard : PaymentStrategy
    {
        private CreditCard card;

        public void CollectPaymentDetails()
        {
            // collect card details
            card = new CreditCard("number", "date", "cvv");
        }

        public void Pay(int amount)
        {
            // using credit card class
            // card = new CreditCard("number", "date", "cvv");

            // operations with Credit card
            Console.WriteLine($"Paying {amount} via Credit Card.");
            card.SetAmount(card.getAmount() - amount);
        }

        public bool ValidatePaymentDetails()
        {
            // validate credit card
            return true;
        }
    }

    // Concrete Strategy: implement different variations of the algorithm the context uses.
    public class PaymentByPayPal : PaymentStrategy
    {
        private string email;
        private string password;

        public void CollectPaymentDetails()
        {
            // collect PayPal access 
            email = "asd";
            password = "ads";
        }

        public void Pay(int amount)
        {
            // getting details for PayPal operation (email, password)

            // operations with Credit card
            Console.WriteLine($"Paying {amount} via PayPal.");
        }

        public bool ValidatePaymentDetails()
        {
            // validate account
            return true;
        }
    }

    public class CreditCard
    {
        private readonly string number;
        private readonly string date;
        private readonly string cvv;
        private int amount = 1_000;

        public CreditCard(string Number, string Date, string Cvv)
        {
            number = Number;
            date = Date;
            cvv = Cvv;
        }

        internal int getAmount()
        {
            return amount;
        }

        internal void SetAmount(int v)
        {
            amount -= v;
        }

        //public int Amount { get; set; } = 1000;
        //public string Number { get; set; }
        //public string Date { get; set; }
        //public string Cvv { get; set; }
    }
}

