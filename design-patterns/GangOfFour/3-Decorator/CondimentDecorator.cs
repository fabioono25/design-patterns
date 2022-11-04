using System;
namespace design_patterns.HeadFirst.Decorator
{
  // the abstract decorator that will serve as base for the concrete ones
  public abstract class CondimentDecorator : Beverage
  {
    public Beverage beverage; // here is the main point
    public abstract string getDescription(); // method that will be overriden by each decorator

    public Size getSize => beverage.getSize();
  }
}

