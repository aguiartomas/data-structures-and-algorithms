using System.Linq;
using DataStructures.LeetCode.Trees.Binary;
using DataStructures.LeetCode.Trees.Binary.Traversal;
using Xunit;

namespace DataStructures.LeetCode.Tests.Trees.Binary.Traversal;

public class PreorderTest
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void Traversal_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, Tree.Add);

        var result = Preorder.Traversal(root);
        
        Assert.Equal(expected.ToList(), result);
    }

    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 2, 3 })]
    public void TraversalIterative_Test(int[] listTree, int[] expected)
    {
        var root = listTree.Aggregate<int, TreeNode?>(null, Tree.Add);

        var result = Preorder.TraversalIterative(root);
        
        Assert.Equal(expected.ToList(), result);
    }
}