namespace GeometricFigures.Backend
{
    public class Kite : GeometricFigure
    {

        // Fields
        private double _a;
        private double _b;
        private double _d1;
        private double _d2;

        // Constructors
        public Kite(string name, double a, double b, double d1, double d2) : base(name)
        {
            A = a;
            B = b;
            D1 = d1;
            D2 = d2;
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

        public double D1
        {
            get => _d1;
            set => _d1 = value;
        }

        public double D2
        {
            get => _d2;
            set => _d2 = value;
        }

        // Methods
        public override double GetArea()
        {
            return (D1 * D2) / 2;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}