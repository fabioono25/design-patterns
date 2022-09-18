using System;
namespace design_patterns.HeadFirst.Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter value {counter}.");
        }

        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void printDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

