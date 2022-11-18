
using MindBoxShapeLibrary2.Models.Abstractions;

namespace MindBoxShapeLibrary2.Models;

public class Triangle : Shape
{
    public Triangle(double aSide, double bSide, double cSide)
    {
        BSide = bSide;
        ASide = aSide;
        CSide = cSide;
        Perimeter = ASide + BSide + CSide;
    }

    public double ASide { get; set; }

    public double BSide { get; set; }

    public double CSide { get; set; }

    public double Perimeter { get; }

    // public override double Square()
    // {
    //     var halfOfPerimeter = Perimeter / 2;
    //     return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - ASide) * (halfOfPerimeter - BSide) * (halfOfPerimeter - CSide));
    // }
}