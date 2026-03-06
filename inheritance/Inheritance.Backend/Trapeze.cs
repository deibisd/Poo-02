namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;

       
        public double D
        {
            get { return _d; }
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        
        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = d;
        }

      
        private void ValidateD(double value)
        {
            if (value <= 0)
                throw new ArgumentException("D must be greater than zero.");
        }

        
        public override double GetArea()
        {
            return ((A + B) / 2) * H; 
        }

        
        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
    }
}