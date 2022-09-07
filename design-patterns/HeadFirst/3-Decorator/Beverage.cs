using System;
namespace design_patterns.HeadFirst.Decorator
{
    // this is the abstract Component class
    public abstract class Beverage
    {
        Size size = Size.TALL;
        public string description = "Unknown beverage";

        public string getDescription() => description;

        public void setSize(Size size)
        {
            this.size = size;
        }

        public Size getSize() => this.size;

        public abstract double cost(); // because it will be overriden by concrete classes
    }

    public enum Size { TALL, GRANDE, VENTI };
}

