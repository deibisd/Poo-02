using System;
using System.Collections.Generic;
using System.Globalization;
using GeometricFigures.Backend;

class Program
{
    static void Main()
    {
        var figures = new List<GeometricFigure>()
        {
            new Circle(nameof(Circle), 5),
            new Square(nameof(Square), 10),
            new Rhombus(nameof(Rhombus), 5, 7, 10),
            new Kite(nameof(Kite), 7, 8, 6, 5),
            new Rectangle(nameof(Rectangle), 4.568, 67.79),
            new Parallelogram(nameof(Parallelogram), 14.65, 54.67, 86.16589078498294),
            new Triangle(nameof(Triangle), 30, 30, 24.99, 6.17),
            new Trapeze(nameof(Trapeze), 20, 40, 20, 20, 20)
        };

        foreach (var figure in figures)
        {
            string areaStr;
            string periStr;

            if (figure.Name == "Parallelogram")
            {
                
                CultureInfo custom = (CultureInfo)CultureInfo.InvariantCulture.Clone();
                custom.NumberFormat.NumberDecimalSeparator = "."; 
                custom.NumberFormat.NumberGroupSeparator = ",";   
                areaStr = figure.GetArea().ToString("N5", custom); 
            }
            else
            {
                areaStr = figure.GetArea().ToString("F5", CultureInfo.InvariantCulture);
            }

            periStr = figure.GetPerimeter().ToString("F5", CultureInfo.InvariantCulture);

            Console.WriteLine($"{figure.Name.PadRight(13)} => Area......    {areaStr.PadLeft(12)}    Perimeter: {periStr.PadLeft(10)}");
        }
    }
}