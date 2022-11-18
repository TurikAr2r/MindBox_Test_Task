using MindBoxShapeLibrary2.Abstractions;
using MindBoxShapeLibrary2.Models;
using MindBoxShapeLibrary2.Models.Abstractions;

namespace MindBoxShapeLibrary2.ShapeOperations;

public class TriangleOperations : ITriangleOperations
{
    public double Square(Shape shape)
    {
        if (shape is not Triangle triangle) 
            throw new ArgumentException("Wrong parameter type");
        
        var halfOfPerimeter = triangle.Perimeter / 2;
        return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - triangle.ASide) * (halfOfPerimeter - triangle.BSide) *
                         (halfOfPerimeter - triangle.CSide));
    }

    public Task<double> SquareAsync(Shape shape)
    {
        throw new NotImplementedException();
    }

    public bool IsRight(Triangle triangle)
    {
        if (triangle.ASide == triangle.BSide && triangle.BSide == triangle.CSide)
            return false;
        
        var (largeTriangleSide, mediumTriangleSide, smallTriangleSide) = GetSidesOrderedBySize(triangle);

        return Math.Pow(mediumTriangleSide, 2) + Math.Pow(smallTriangleSide, 2) == Math.Pow(largeTriangleSide, 2);
    }
    
    private (double largeSide, double mediumSide, double smallSite) GetSidesOrderedBySize(Triangle triangle)
    {
        var orderedList = new List<double>( new [] {triangle.ASide, triangle.BSide, triangle.CSide}).OrderByDescending(x=>x).ToList();

        return (orderedList[0], orderedList[1], orderedList[2]);
    }
}