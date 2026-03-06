namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        
        private double _a;

        
        public double A
        {
            get { return _a; }
            set
            {
                ValidateA(value);
                _a = value;
            }
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        private void ValidateA(double value)
        {
            if (value <= 0)
                throw new ArgumentException("A must be greater than zero.");
        }

        public override double GetArea()
        {
            return _a * _a;
        }

        public override double GetPerimeter()
        {
            return 4 * _a;
        }
    }
}