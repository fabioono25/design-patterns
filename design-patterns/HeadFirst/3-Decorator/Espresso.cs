using System;
namespace design_patterns.HeadFirst.Decorator
{
  // these are the concrete Components that will be decorated
  public class Espresso : Beverage
  {
    public Espresso()
    {
      description = "Espresso Coffee";
    }

    public override double cost() => 1.99;
  }

  public class Decaf : Beverage
  {
    public Decaf()
    {
      description = "Decaf Coffee";
    }

    public override double cost() => 1.01;
  }

  public class DarkRoast : Beverage
  {
    public DarkRoast()
    {
      description = "Dark Roast Coffee";
    }

    public override double cost() => 2.99;
  }
}

