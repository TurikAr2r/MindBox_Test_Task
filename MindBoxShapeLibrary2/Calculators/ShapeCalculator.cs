using MindBoxShapeLibrary2.Abstractions;
using MindBoxShapeLibrary2.Models;
using MindBoxShapeLibrary2.Models.Abstractions;
using MindBoxShapeLibrary2.ShapeOperations;

namespace MindBoxShapeLibrary2.Calculators;

public class ShapeCalculator
{
    private IShapeOperations _shapeOperations;
    
    public double Square<T>(T shape) where T : Shape
    {
        _shapeOperations = GetShapeOperations(shape);
        return _shapeOperations.Square(shape);
    }

    public Task<double> SquareAsync<T>(T shape) where T : Shape
    {
        _shapeOperations = GetShapeOperations(shape);
        return _shapeOperations.SquareAsync(shape);
    }
    
    private IShapeOperations GetShapeOperations<T>(T shape) where T : Shape
    {
        return shape switch
        {
            Circle circle => new CircleOperations(),
            Triangle triangle => new TriangleOperations(),
            _ => throw new ArgumentException("Type is invalid")
        }; 
    }
}