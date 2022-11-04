using design_patterns.HeadFirst.DucksProblem;
using Xunit;
using PaymentServiceOld = design_patterns.GangOfFour.Structural.Strategy.Payment.Problem.PaymentService;

namespace design_patternsTests.HeadFirst.DucksProblem
{
    public class DucksTests
    {
        [Fact]
        public void ShouldReturnTheSameInstance(){
            var mallardDuck = new MallardDuck();
            //var rubberDuck = new RubberDuck();
            //rubberDuck.performFly(); // ERROR: rubber ducks cannot fly!!!

            mallardDuck.display();
            mallardDuck.performFly();
            mallardDuck.performQuack();

            // now, we will test the behavior being changed during runtime
            var modelDuck = new ModelDuck();
            modelDuck.display();
            modelDuck.performFly();
            modelDuck.setFlyStrategy(new FlyRocket());
            modelDuck.performFly();
        }

        [Fact]
        public void PaymentServiceProblemTest()
        {
            var paymentService = new PaymentServiceOld(23, true);
            paymentService.ProcessOrder("CreditCard");
            paymentService.ProcessOrder("PayPal");
        }
    }
}