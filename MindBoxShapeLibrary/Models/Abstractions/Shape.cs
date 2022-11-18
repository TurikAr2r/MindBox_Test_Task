namespace MindBoxShapeLibrary.Models.Abstractions;

public abstract class Shape
{
    public abstract double Square();

    public abstract Task<double> SquareAsync();
}