using System;

namespace design_patterns.Creational.Singleton.Basic
{
    public class SingleObject
    {
        // create an object
        private static SingleObject instance = new SingleObject();

        // constructor private - class cannot be instantiated
        private SingleObject(){}

        // get the object available - entry point for the client
        public static SingleObject getInstance() => instance;
        public int SomeValue { get; set; }
    }
}
