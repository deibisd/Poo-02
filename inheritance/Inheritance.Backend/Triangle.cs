namespace GeometricFigures.Backend
{
    public class Triangle : GeometricFigure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _h;

        public Triangle(string name, double a, double b, double c, double h) : base(name)
        {
            A = a;
            B = b;
            C = c;
            H = h;
        }

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

        public double H
        {
            get => _h;
            set => _h = value;
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }
}