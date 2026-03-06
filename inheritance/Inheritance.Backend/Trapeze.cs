namespace GeometricFigures.Backend
{
    public class Trapezze : GeometricFigure
    {
        // Fields
        private double _a;
        private double _b;
        private double _c;
        private double _d;
        private double _h;

        // Constructor
        public Trapezze(string name, double a, double b, double c, double d, double h) : base(name)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
        }

        // Properties
        public double A
        {
            get => _a;
            set => _a = value;
        }

        public double B
        {
            get => _b;
            set => _b = value;
        }

        public double C
        {
            get => _c;
            set => _c = value;
        }

        public double D
        {
            get => _d;
            set => _d = value;
        }

        public double H
        {
            get => _h;
            set => _h = value;
        }

        // Methods
        public override double GetArea()
        {
            return (A + B) * H;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
    }
}