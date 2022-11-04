using System;
using design_patterns.HeadFirst.Decorator;
using design_patterns.HeadFirst.Factory.SimpleFactory;
using Xunit;

namespace design_patternsTests.HeadFirst.Factory.SimpleFactory
{
    public class SimpleFactoryTests
    {
        [Fact]
        public void ShouldExecuteTest()
        {
            var factory = new SimplePizzaFactory();

            var pizzaStore = new PizzaStore(factory);
            var pizza = pizzaStore.orderPizza("veggie");
            Console.WriteLine(pizza.toString());

            pizza = pizzaStore.orderPizza("clam");
            Console.WriteLine(pizza.toString());

        }
    }
}

