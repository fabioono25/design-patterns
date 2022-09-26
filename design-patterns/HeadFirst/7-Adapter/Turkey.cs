using System;

namespace design_patterns.HeadFirst.Adapter
{
    public interface Turkey
    {
        public void gobble();
        public void fly();
    }

    public class WildTurkey : Turkey
    {
        public void gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }

        public void fly()
        {
            Console.WriteLine("I am flying a short distance");
        }
    }

    public class TurkeyAdapter : Duck
    {
        private readonly Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.fly();
            }
        }

        public void quack()
        {
            _turkey.gobble();
        }
    }
}

