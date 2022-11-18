using MindBoxShapeLibrary.Abstractions;
using MindBoxShapeLibrary.Models.Abstractions;

namespace MindBoxShapeLibrary.Models;

public class Triangle : Shape, ITriangle
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

    public override double Square()
    {
        var halfOfPerimeter = Perimeter / 2;
        return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - ASide) * (halfOfPerimeter - BSide) * (halfOfPerimeter - CSide));
    }

    public override Task<double> SquareAsync()
    {
        throw new NotImplementedException();
    }

    public bool IsRight()
    {
        if (ASide == BSide && BSide == CSide)
            return false;
        
        var (largeTriangleSide, mediumTriangleSide, smallTriangleSide) = GetSidesOrderedBySize();

        return Math.Pow(mediumTriangleSide, 2) + Math.Pow(smallTriangleSide, 2) == Math.Pow(largeTriangleSide, 2);
    }

    private (double largeSide, double mediumSide, double smallSite) GetSidesOrderedBySize()
    {
        var orderedList = new List<double>( new [] {ASide, BSide, CSide}).OrderByDescending(x=>x).ToList();

        return (orderedList[0], orderedList[1], orderedList[2]);
    }
}