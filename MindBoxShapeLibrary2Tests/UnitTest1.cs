using MindBoxShapeLibrary2.Abstractions;
using MindBoxShapeLibrary2.Calculators;
using MindBoxShapeLibrary2.Models;
using MindBoxShapeLibrary2.Models.Abstractions;
using MindBoxShapeLibrary2.ShapeOperations;
using Xunit;

namespace MindBoxShapeLibrary2Tests;

public class UnitTest1
{
    [Fact]
    public void TestTriangle()
    {
        //Arrange
        var triangle = new Triangle(12d,13d,15d);
        ShapeCalculator calculator = new ShapeCalculator();
        
        //Act
        var triangleSquare = calculator.Square(triangle);
        
        //Assert
        Assert.Equal("74,83", $"{triangleSquare:N2}");
    }
    
    [Fact]
    public void TestCircle()
    {
        //Arrange
        var circle = new Circle(12d);
        var shapeCalculator = new ShapeCalculator();

        //Act
        var square = shapeCalculator.Square(circle);
        
        //Assert
        Assert.Equal("452,39", $"{square:N2}");
    }
    
    [Fact]
    public void TestCross()
    {
        //Arrange
        Shape shape = new Circle(5d);
        var calculator = new ShapeCalculator();
        
        //Act
        var shapeSquare = calculator.Square(shape);

        //Assert
        Assert.Equal("78,54", $"{shapeSquare:N2}");

        //Arrange
        shape = new Triangle(12d,13d,15d);
        
        //Act
        shapeSquare = calculator.Square(shape);

        //Assert
        Assert.Equal("74,83", $"{shapeSquare:N2}");
    }

    [Fact]
    public void TestTriangleIsRightCheck()
    {
        //Arrange
        var (aSide, bSide, cSide) = (3d, 4d, 5d);
        var triangle = new Triangle(aSide, bSide, cSide);
        ITriangleOperations triangleOperationsOperations = new TriangleOperations();
        
        //Act
        var isRight = triangleOperationsOperations.IsRight(triangle);
        
        //Assert
        Assert.True(isRight);
        
        //Arrange
        triangle.CSide = 7d;
        
        //Act
        isRight = triangleOperationsOperations.IsRight(triangle);
        
        //Assert
        Assert.False(isRight);
    
    }
}