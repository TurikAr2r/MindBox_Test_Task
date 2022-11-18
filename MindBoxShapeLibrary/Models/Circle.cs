using MindBoxShapeLibrary.Models.Abstractions;

namespace MindBoxShapeLibrary.Models;

public class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Radius { get; set; }
    
    public override double Square()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override Task<double> SquareAsync()
    {
        throw new NotImplementedException();
    }
}