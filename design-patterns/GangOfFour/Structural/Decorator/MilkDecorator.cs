using System;
namespace design_patterns.HeadFirst.Decorator
{
  // concrete decorator classes
  public class MilkDecorator : CondimentDecorator
  {
    public MilkDecorator(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double cost() => beverage.cost() + .10;

    public override string getDescription() => beverage.getDescription() + ", Milk";
  }

  public class Mocha : CondimentDecorator
  {
    public Mocha(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double cost() => beverage.cost() + .20;

    public override string getDescription() => beverage.getDescription() + ", Mocha";
  }

  public class Soy : CondimentDecorator
  {
    public Soy(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double cost() => beverage.cost() + .30;

    public override string getDescription() => beverage.getDescription() + ", Soy";
  }

  public class Whip : CondimentDecorator
  {
    public Whip(Beverage beverage)
    {
      this.beverage = beverage;
    }

    public override double cost() => beverage.cost() + .40;

    public override string getDescription() => beverage.getDescription() + ", Whip";
  }
}

