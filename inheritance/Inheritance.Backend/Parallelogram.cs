namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        private double _h;

        public double H
        {
            get { return _h; }
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Parallelogram(string name, double a, double b, double h)
            : base(name, a, b)
        {
            H = h;
        }

        private void ValidateH(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("H must be greater than zero.");
            }
        }

        public override double GetArea()
        {
            return A * _h;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}