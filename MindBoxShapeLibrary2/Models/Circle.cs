
using MindBoxShapeLibrary2.Models.Abstractions;

namespace MindBoxShapeLibrary2.Models;

public class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double Radius { get; set; }
}