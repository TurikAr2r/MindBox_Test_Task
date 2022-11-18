using MindBoxShapeLibrary2.Models;

namespace MindBoxShapeLibrary2.Abstractions;

public interface ITriangleOperations : IShapeOperations
{
    bool IsRight(Triangle triangle);
}