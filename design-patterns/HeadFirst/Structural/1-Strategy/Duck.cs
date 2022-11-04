using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns.HeadFirst.DucksProblem
{
    public abstract class Duck
    {
        public FlyStrategy flyStrategy;
        public QuackStrategy quackStrategy;

        public Duck()
        {
        }

        public void performQuack() {
            quackStrategy.quack();
        }

        public void swim() {
            System.Console.WriteLine("Swim from Duck class!");
        }

        public abstract void display();

        // new behavior
        public void performFly()
        {
            flyStrategy.fly();
        }

        // adding behavior dynamically
        public void setFlyStrategy(FlyStrategy fb)
        {
            this.flyStrategy = fb;
        }

        public void setQuackStrategy(QuackStrategy qb)
        {
            this.quackStrategy = qb;
        }
    }

    public interface FlyStrategy
    {
        public void fly();
    }

    public class FlyWithWings : FlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("I am flying with wings!");
        }
    }

    public class FlyNoWay : FlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("I cannot fly!");
        }
    }

    public class FlyRocket : FlyStrategy
    {
        public void fly()
        {
            Console.WriteLine("I am flying with a Rocket!!!");
        }
    }

    public interface QuackStrategy
    {
        public void quack();
    }

    public class Quack : QuackStrategy
    {
        public void quack()
        {
            Console.WriteLine("I can quack!");
        }
    }

    public class Squeak : QuackStrategy
    {
        public void quack()
        {
            Console.WriteLine("I can squeak!!!");
        }
    }

    public class MuteQuack : QuackStrategy
    {
        public void quack()
        {
            Console.WriteLine("##mute##");
        }
    }

    public class MallardDuck : Duck {
        public MallardDuck()
        {
            quackStrategy = new Quack();
            flyStrategy = new FlyWithWings();
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
            flyStrategy = new FlyNoWay();
            quackStrategy = new Quack();
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