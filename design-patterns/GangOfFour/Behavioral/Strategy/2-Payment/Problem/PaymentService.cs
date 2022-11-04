using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns.GangOfFour.Structural.Strategy.Payment.Problem
{
    public class PaymentService
    {
        private readonly int cost;
        private readonly bool includeDelivery;

        public PaymentService(int cost, bool includeDelivery)
        {
            this.cost = cost;
            this.includeDelivery = includeDelivery;
        }

        /// <summary>
        /// This is the problem. Every time we add a new payment method, we incur in adding more responsibility to this method
        /// And more, we can break the already implemented ways of payment (Credit Card, for example)
        /// OCP and SRP violation
        /// </summary>
        /// <param name="paymentMethod"></param>
        public void ProcessOrder(string paymentMethod) {
            switch (paymentMethod)
            {
                case "CreditCard":
                    // using credit card class
                    var creditCard = new CreditCard("number", "date", "cvv");

                    // operations with Credit card
                    var total = GetTotal();

                    Console.WriteLine($"Paying {total} via Credit Card.");
                    break;

                case "PayPal":

                    // getting details for PayPal operation (email, password)

                    Console.WriteLine($"Paying {GetTotal()} via PayPal.");
                    break;

                default:
                    Console.WriteLine($"Nothing payment type defined.");
                    break;
            }
        }

        private int GetTotal() => includeDelivery ? cost + 10 : cost;
    }

    public class CreditCard {
        private readonly string number;
        private readonly string date;
        private readonly string cvv;

        public CreditCard(string Number, string Date, string Cvv)
        {
            number = Number;
            date = Date;
            cvv = Cvv;
        }

        //public int Amount { get; set; } = 1000;
        //public string Number { get; set; }
        //public string Date { get; set; }
        //public string Cvv { get; set; }
    }
}