using System;
using design_patterns.HeadFirst.Factory.AbstractFactory;
using Xunit;

namespace design_patternsTests.HeadFirst.Factory.AbstractFactory
{
    public class AbstractFactoryTests
    {
        [Fact]
        public void ShouldExecuteTest()
        {
            var nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.orderPizza("cheese");
        }
    }
}

