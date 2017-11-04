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
            var node = new Node<int>(5)
            {
                3,
                1,
                4,
                9,
                11
            };
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