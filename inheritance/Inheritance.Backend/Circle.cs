namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get { return _r; }
            set
            {
                ValidateR(value);
                _r = value;
            }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        private void ValidateR(double r)
        {
            if (r <= 0)
                throw new ArgumentException("R must be greater than zero.");
        }

        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }
    }
}