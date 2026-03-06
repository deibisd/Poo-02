using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {

        // Fields
        private double _r;

        // Constructors
        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        // Properties
        public double R
        {
            get => _r;
            set => _r = value;
        }

        // Methods
        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }
    }
}