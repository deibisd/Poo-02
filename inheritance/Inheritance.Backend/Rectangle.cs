namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        
        private double _b;

       
        public double B
        {
            get { return _b; }
            set
            {
                ValidateB(value);
                _b = value;
            }
        }

        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }

        private void ValidateB(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("B must be greater than zero.");
            }
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}