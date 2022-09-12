using System;
using design_patterns.HeadFirst.Decorator;
using design_patterns.HeadFirst.Factory.FactoryMethod;
using design_patterns.HeadFirst.Factory.SimpleFactory;
using Xunit;

namespace design_patternsTests.HeadFirst.Factory.SimpleFactory
{
    public class FactoryMethodTests
    {
        [Fact]
        public void ShouldExecuteTest()
        {
            var nyPizzaStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            nyPizzaStore.orderPizza("veggie");
            chicagoStore.orderPizza("veggie");
        }
    }
}

