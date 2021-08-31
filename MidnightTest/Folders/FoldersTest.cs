using FluentAssertions;
using Midnight;
using Xunit;
using System.Linq;

namespace MidnightTest
{
    public class FoldersTest
    {
        private string _xml = 
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        [Fact]
        public void ShouldReturnCorrectValuesOnIEnumerableOfString()
        {
            var result = Folders.FolderNames(_xml, 'u').ToArray();
            result[0].Should().Be("uninstall information");
            result[1].Should().Be("users");
        }
    }
}
