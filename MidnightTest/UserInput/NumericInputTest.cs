using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using System.Linq;

namespace MidnightTest
{
    public class NumericInputTest : IClassFixture<NumericInputFixture>
    {
        private readonly NumericInputFixture _numericInputFixture;

        public NumericInputTest(NumericInputFixture numericInputFixture)
        {
            _numericInputFixture = numericInputFixture;
        }

        [Theory]
        [InlineData(new char[] { 'a', '2', '4', 'e', 'l', '8', '0', 'k' }, "2480")]
        [InlineData(new char[] { '2', '6', '0', '5' }, "2605")]
        [InlineData(new char[] { 'a', 'e', 'k' }, "")]
        public void ShouldReturnOnlyDigits(char[] characteres, string expectedResult)
        {
            var list = characteres.ToList();
            list.ForEach(ac => _numericInputFixture.numericInput.Add(ac));
            var result = _numericInputFixture.numericInput.GetValue();
            result.Should().Be(expectedResult);
            _numericInputFixture.NewInstance();
        }
    }
}
