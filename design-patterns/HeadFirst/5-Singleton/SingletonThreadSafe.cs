using System;
namespace design_patterns.HeadFirst.Singleton
{
    // using a thread-safe approach to controls the thread race condition in a multithread environment.
    public sealed class SingletonThreadSafe
    {
        private static int counter = 0;
        private static readonly object InstanceLock = new object();
        private static SingletonThreadSafe instance = null;

        private SingletonThreadSafe()
        {
            counter++;
            Console.WriteLine($"Counter value {counter}.");
        }

        public static SingletonThreadSafe getInstance()
        {
            lock (InstanceLock)
            {
                if (instance == null)
                {
                    instance = new SingletonThreadSafe();
                }
                return instance;
            }
        }

        public void printDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}

