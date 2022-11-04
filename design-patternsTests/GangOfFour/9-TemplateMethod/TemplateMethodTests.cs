using System;
using design_patterns.HeadFirst.TemplateMethod;
using Xunit;

namespace design_patternsTests.HeadFirst.TemplateMethod
{
    public class TemplateMethodTests
    {
        [Fact]
        public void WorkingWithFacade()
        {
            TeaWithHook teaHook = new TeaWithHook();
            CoffeeWithHook coffeeHook = new CoffeeWithHook();

            Console.WriteLine("\nMaking tea...");
            teaHook.prepareRecipe();

            Console.WriteLine("\nMaking coffee...");
            coffeeHook.prepareRecipe();
        }
    }
}

