using Xunit;
using FluentAssertions;
using Midnight;

namespace MidnightTest
{
    public class QuadraticEquationTest
    {
        [Fact]
        public void ShouldReturnTupleWithCorrectValues()
        {
            var result = QuadraticEquation.FindRoots(2, 10, 8);
            result.Item1.Should().Be(-1.0);
            result.Item2.Should().Be(-4.0);
        }
    }
}
