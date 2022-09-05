using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns.HeadFirst.DucksProblem
{
    public class Duck
    {
        public void Quack() {
            System.Console.WriteLine("Quack from Duck class!");
        }

        public void Swim() {
            System.Console.WriteLine("Swim from Duck class!");
        }

        public void Display() {
            System.Console.WriteLine("Display from Duck class!");
        }

        // new behavior
        public virtual void Fly()
        {
            System.Console.WriteLine("Fly from Duck class!");
        }
    }

    public class MallardDuck : Duck {
        
    }

    public class ReadheadDuck : Duck {

    }

    public class RubberDuck : Duck {
        public override void Fly()
        {
            Console.WriteLine("I am a rubber duck and cannot fly (overriden from base class)!");
        }
    }
}