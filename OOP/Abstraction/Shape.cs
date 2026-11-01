using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    /// any shape must have a method to calculate its area
    /// and method to calculate its perimeter
    /// and ensuere that dimensions are valid, must be positive numbers

    /// ex : square has a side length, 
    /// rectangle has width and height, 
    /// circle has radius

    interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }


    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        protected static double ValidateDimension(double Dimension, string DimensionName)
        {
            if (Dimension <= 0)
            {
                throw new ArgumentException($"{DimensionName} Must Be Greater than Zero");
            }

            return Dimension;
        }
    }

    class Sqare : Shape
    {
        public double Side { get; }

        public Sqare(double _side)
        {
            Side = ValidateDimension(_side, nameof(Side));
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }
    }

    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double _width, double _height)
        {
            Width = ValidateDimension(_width, nameof(Width));
            Height = ValidateDimension(_height, nameof(Height));
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double _radius)
        {
            Radius = ValidateDimension(_radius, nameof(Radius));
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

}
