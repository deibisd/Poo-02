namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {

        // Fields
        private double _a;

        // Constructors
        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        // Properties
        public double A
        {
            get => _a;
            set => _a = value;
        }

        // Methods
        public override double GetArea()
        {
            return A * A;
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }
    }
}