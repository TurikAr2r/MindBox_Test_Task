using MindBoxShapeLibrary2.Abstractions;
using MindBoxShapeLibrary2.Models;
using MindBoxShapeLibrary2.Models.Abstractions;

namespace MindBoxShapeLibrary2.ShapeOperations;

public class CircleOperations : IShapeOperations
{
    public double Square(Shape shape)
    {
        if (shape is not Circle circle)
            throw new ArgumentException("Wrong parameter type");
        
        return Math.PI * Math.Pow(circle.Radius, 2);
    }

    public Task<double> SquareAsync(Shape shape)
    {
        throw new NotImplementedException();
    }
}