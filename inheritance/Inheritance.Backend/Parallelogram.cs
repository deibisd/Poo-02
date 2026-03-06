namespace GeometricFigures.Backend
{
    public class Parallelogram : GeometricFigure
    {
        private double _a;
        private double _b;
        private double _h;

        public Parallelogram(string name, double a, double b, double h) : base(name)
        {
            A = a;
            B = b;
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

        public double H
        {
            get => _h;
            set => _h = value;
        }

        public override double GetArea()
        {
            return B * H;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}