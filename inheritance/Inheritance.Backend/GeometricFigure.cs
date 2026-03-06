using System.Globalization;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        // Fields
        private string _name = string.Empty;

        // Constructors
        public GeometricFigure(string name)
        {
            Name = name;
        }

        // Properties
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        // Methods
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return string.Format(new CultureInfo("en-US"),
                "{0,-15} => Area......: {1,12:N5}    Perimiter: {2,10:N5}",
                Name, GetArea(), GetPerimeter());
        }
    }
}