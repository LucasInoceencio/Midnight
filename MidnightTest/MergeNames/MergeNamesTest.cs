using Xunit;
using Midnight;
using FluentAssertions;

namespace MidnightTest
{
    public class MergeNamesTest
    {
        [Theory]
        [InlineData(new string[] { "Ava", "Emma", "Olivia" }, new string[] { "Olivia", "Sophia", "Emma" }, "Ava, Emma, Olivia, Sophia")]
        public void ShouldReturnDistinctOfTwoArraysOfString(string[] names1, string[] names2, string concatResult)
        {
            string result = string.Join(", ", MergeNames.UniqueNames(names1, names2));
            result.Should().Be(concatResult);
        }

        [Theory]
        [InlineData(new string[] { "Ava", "Emma", "Olivia" }, new string[] { "Olivia", "Sophia", "Emma" })]
        public void ShouldReturnArrayOfStringWithFourElements(string[] names1, string[] names2)
        {
            var result = MergeNames.UniqueNames(names1, names2);
            result.Length.Should().Be(4);
        }
    }
}
