using MindBoxShapeLibrary.Abstractions;
using MindBoxShapeLibrary.Models;
using MindBoxShapeLibrary.Models.Abstractions;
using Xunit;

namespace MindBoxShapeLibraryTests;

public class UnitTest1
{
    [Fact]
    public void TestTriangle()
    {
        Shape shape = new Triangle(12d,13d,15d);

        //Act
        var square = shape.Square();
        
        //Assert
        
        Assert.Equal("74,83", $"{square:N2}");
    }
    
    [Fact]
    public void TestCircle()
    {
        Shape shape = new Circle(12d);

        //Act
        var square = shape.Square();
        
        //Assert
        Assert.Equal("452,39", $"{square:N2}");
    }
    
    [Fact]
    public void TestCross()
    {
        Shape shape = new Circle(12d);
        
        var circleSquare = shape.Square();
        
        Assert.Equal("452,39", $"{circleSquare:N2}");
        
        shape = new Triangle(12d,13d,15d);

        var triangleSquare = shape.Square();
        
        Assert.Equal("74,83", $"{triangleSquare:N2}");
        
    }
    
    [Fact]
    public void TestTriangleIsRightCheck()
    {
        var (aSide, bSide, cSide) = (3d, 4d, 5d);
        Shape shape = new Triangle(aSide, bSide, cSide);

        var triangle = shape as Triangle;

        var isRight = triangle.IsRight();
        Assert.True(isRight);

        triangle.CSide = 7d;
        isRight = triangle.IsRight();
        
        Assert.False(isRight);

    }
}