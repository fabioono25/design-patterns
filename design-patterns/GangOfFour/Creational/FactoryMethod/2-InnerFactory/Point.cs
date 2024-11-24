using System;

namespace design_patterns.GangOfFour.Creational.FactoryMethod.Points
{
    public class Point
    {
        private double x, y;

        // old-way
        //public Point(double x, double y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        // implement Factory Method

        // private or internal constructor
        // internal Point(double x, double y)
        // {
        //     this.x = x;
        //     this.y = y;
        // }

        // indicating the origin
        public static Point Origin => new Point(0, 0); // property, instantiated each time it is called
        public static Point Origin2 = new Point(0, 0); // field, instantiated only once (Singleton)

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static class Factory
        {
            // factory methods
            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
            }

            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
        }
    }
}