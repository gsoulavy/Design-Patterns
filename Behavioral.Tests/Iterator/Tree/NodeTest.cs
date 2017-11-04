namespace Behavioral.Tests.Iterator.Tree
{
    using System.Collections.Generic;
    using Xunit;
    using Behavioral.Iterator.Tree;

    public class NodeTest
    {
        [Fact(DisplayName = "Iterator: Tree")]
        public void IteratorTest()
        {
            var node = new Node<int>(5);
            node.Add(3);
            node.Add(1);
            node.Add(4);
            node.Add(9);
            node.Add(11);
            Assert.NotNull(node);

            var values = new List<int>();
            foreach (var i in node)
            {
                values.Add(i);
            }

            var result = string.Join(" ", values);

            Assert.Equal("5 3 4 9 1 11", result);
        }
    }
}