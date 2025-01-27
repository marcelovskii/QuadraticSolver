using Quadratic_Solver;
using System;
using Xunit;

public class QuadraticSolverTests
{
    [Theory]
    [InlineData(1, -3, 2, 2, 2.0, 1.0)] // Dwa pierwiastki: x1=2, x2=1
    [InlineData(1, 2, 1, 1, -1.0, null)] // Jeden pierwiastek: x1=-1
    [InlineData(1, 0, 1, 0, null, null)] // Brak pierwiastków rzeczywistych
    public void TestSolve(double a, double b, double c, int expectedRoots, double? expectedX1, double? expectedX2)
    {
        var result = QuadraticSolver.Solve(a, b, c);
        Assert.Equal(expectedRoots, result.Item1);
        Assert.Equal(expectedX1, result.Item2);
        Assert.Equal(expectedX2, result.Item3);
    }

    [Fact]
    public void TestNonQuadraticEquation()
    {
        Assert.Throws<ArgumentException>(() => QuadraticSolver.Solve(0, 2, 1));
    }
}
