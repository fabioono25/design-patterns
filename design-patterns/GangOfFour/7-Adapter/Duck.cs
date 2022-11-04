using System;
namespace design_patterns.HeadFirst.Adapter
{
    public interface Duck
    {
        public void quack();
        public void fly();
    }

    public class MallardDuck : Duck
    {
        public void fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void quack()
        {
            Console.WriteLine("Quack!!");
        }
    }
}

