using Xunit;
using FluentAssertions;
using Midnight;

namespace MidnightTest
{
    public class AccountTest
    {
        [Theory]
        [InlineData(Account.Access.Delete)]
        [InlineData(Account.Access.Publish)]
        [InlineData(Account.Access.Comment)]
        public void ShouldReturnFalseWhenWriterHasNotTag(Account.Access tag)
        {
            Account.Access.Writer.HasFlag(tag).Should().BeFalse();
        }

        [Theory]
        [InlineData(Account.Access.Submit)]
        [InlineData(Account.Access.Modify)]
        public void ShouldReturnTrueWhenWriterHasTag(Account.Access tag)
        {
            Account.Access.Writer.HasFlag(tag).Should().BeTrue();
        }

        [Theory]
        [InlineData(Account.Access.Submit)]
        [InlineData(Account.Access.Modify)]
        public void ShouldReturnFalseWhenEditorHasNotTag(Account.Access tag)
        {
            Account.Access.Editor.HasFlag(tag).Should().BeFalse();
        }

        [Theory]
        [InlineData(Account.Access.Delete)]
        [InlineData(Account.Access.Publish)]
        [InlineData(Account.Access.Comment)]
        public void ShouldReturnTrueWhenEditorHasTag(Account.Access tag)
        {
            Account.Access.Editor.HasFlag(tag).Should().BeTrue();
        }

        [Theory]
        [InlineData(Account.Access.Delete)]
        [InlineData(Account.Access.Publish)]
        [InlineData(Account.Access.Submit)]
        [InlineData(Account.Access.Comment)]
        [InlineData(Account.Access.Modify)]
        [InlineData(Account.Access.Writer)]
        [InlineData(Account.Access.Editor)]
        public void ShouldReturnTrueWhenOwnerHasTag(Account.Access tag)
        {
            Account.Access.Owner.HasFlag(tag).Should().BeTrue();
        }
    }
}
