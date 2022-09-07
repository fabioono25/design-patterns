using System;
using design_patterns.HeadFirst.Decorator;
using design_patterns.HeadFirst.Observer;
using Xunit;

namespace design_patternsTests.HeadFirst.Decorator
{
  public class DecoratorTests
  {
    [Fact]
    public void ShouldReturnTheSameInstance()
    {
      Beverage beverage = new Espresso();
      Console.WriteLine($"{beverage.getDescription()} - $ {beverage.cost().ToString("C")}");

      Beverage beverage2 = new DarkRoast();
      beverage2 = new Mocha(beverage2);
      beverage2 = new Mocha(beverage2);
      beverage2 = new Whip(beverage2);
      Console.WriteLine($"{beverage.getDescription()} - $ {beverage2.cost().ToString("C")}");

      Beverage beverage3 = new Decaf();
      beverage3.setSize(Size.VENTI);
      beverage3 = new Soy(beverage3);
      beverage3 = new Mocha(beverage3);
      beverage3 = new Whip(beverage3);
      Console.WriteLine($"{beverage.getDescription()} - $ {beverage3.cost().ToString("C")}");
    }
  }
}

