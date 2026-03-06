namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        
        private double _c;
        private double _h;

 
        public double C
        {
            get { return _c; }
            set
            {
                ValidateC(value);
                _c = value;
            }
        }

        public double H
        {
            get { return _h; }
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            C = c;
            H = h;
        }

        private void ValidateC(double value)
        {
            if (value <= 0)
                throw new ArgumentException("C must be greater than zero.");
        }

        private void ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException("H must be greater than zero.");
        }

        public override double GetArea()
        {
            return (A * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}