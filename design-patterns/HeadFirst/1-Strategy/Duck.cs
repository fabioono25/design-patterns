using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns.HeadFirst.DucksProblem
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck()
        {
        }

        public void performQuack() {
            quackBehavior.quack();
        }

        public void swim() {
            System.Console.WriteLine("Swim from Duck class!");
        }

        public abstract void display();

        // new behavior
        public void performFly()
        {
            flyBehavior.fly();
        }

        // adding behavior dynamically
        public void setFlyBehavior(FlyBehavior fb)
        {
            this.flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            this.quackBehavior = qb;
        }
    }

    public interface FlyBehavior
    {
        public void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying with wings!");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I cannot fly!");
        }
    }

    public class FlyRocket : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying with a Rocket!!!");
        }
    }

    public interface QuackBehavior
    {
        public void quack();
    }

    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("I can quack!");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("I can squeak!!!");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("##mute##");
        }
    }

    public class MallardDuck : Duck {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a real Mallad duck!");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I am a Model Duck!");
        }
    }

    public class ReadheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("I am a Redhead duck!");
        }
    }

    public class RubberDuck : Duck
    {
        //public override void fly()
        //{
        //    Console.WriteLine("I am a rubber duck and cannot fly (overriden from base class)!");
        //}
        public override void display()
        {
            Console.WriteLine("I am a rubber duck!");
        }
    }
}