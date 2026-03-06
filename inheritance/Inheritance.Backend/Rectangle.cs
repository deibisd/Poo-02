namespace GeometricFigures.Backend
{
    public class Rectangle : GeometricFigure
    {

        // Fields
        private double _a;
        private double _b;

        // Constructors
        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
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

        // Methods
        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }
}