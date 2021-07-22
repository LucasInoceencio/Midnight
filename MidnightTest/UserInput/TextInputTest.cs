using FluentAssertions;
using System.Linq;
using Xunit;

namespace MidnightTest
{
    public class TextInputTest : IClassFixture<TextInputFixture>
    {
        private readonly TextInputFixture _numericInputFixture;

        public TextInputTest(TextInputFixture numericInputFixture)
        {
            _numericInputFixture = numericInputFixture;
        }

        [Theory]
        [InlineData(new char[] { 'a', '2', '4', 'e', 'l', '8', '0', 'k' }, "a24el80k")]
        [InlineData(new char[] { '2', '6', '0', '5' }, "2605")]
        [InlineData(new char[] { 'a', 'e', 'k' }, "aek")]
        public void ShouldReturnAllCharacteres(char[] characteres, string expectedResult)
        {
            var list = characteres.ToList();
            list.ForEach(ac => _numericInputFixture.textInput.Add(ac));
            var result = _numericInputFixture.textInput.GetValue();
            result.Should().Be(expectedResult);
            _numericInputFixture.NewInstance();
        }
    }
}
