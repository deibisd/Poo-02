namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
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

        public Kite(string name, double a, double b, double d1, double d2)
            : base(name, a, d1, d2)
        {
            B = b;
        }

        private void ValidateB(double b)
        {
            if (b <= 0)
                throw new ArgumentException("B must be greater than zero.");
        }

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}