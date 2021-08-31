using FluentAssertions;
using Midnight;
using Xunit;

namespace MidnightTest
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void ShouldReturnTrueToFindExistElement()
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            BinarySearchTree.Contains(n2, 2).Should().BeTrue();
        }
    }
}
