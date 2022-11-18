using MindBoxShapeLibrary2.Models.Abstractions;

namespace MindBoxShapeLibrary2.Abstractions;

public interface IShapeOperations
{
    double Square(Shape shape);
    
    Task<double> SquareAsync(Shape shape);
}