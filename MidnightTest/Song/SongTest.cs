using Xunit;
using Midnight;
using FluentAssertions;

namespace MidnightTest
{
    public class SongTest : IClassFixture<SongFixture>
    {
        private readonly SongFixture _songFixture;

        public SongTest(SongFixture songFixture)
        {
            _songFixture = songFixture;
        }

        [Fact]
        public void ShouldReturnFalseWhenSongNotRepeat()
        {
            _songFixture.firstUnique.IsRepeatingPlaylist().Should().BeFalse();
            _songFixture.secondUnique.IsRepeatingPlaylist().Should().BeFalse();
            _songFixture.thirdUnique.IsRepeatingPlaylist().Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWhenSongRepeat()
        {
            _songFixture.firstRepeated.IsRepeatingPlaylist().Should().BeTrue();
            _songFixture.secondRepeated.IsRepeatingPlaylist().Should().BeTrue();
            _songFixture.thirdRepeated.IsRepeatingPlaylist().Should().BeTrue();
        }
    }
}
