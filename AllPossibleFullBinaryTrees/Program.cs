using System.Collections;
using System.Security.AccessControl;

Solution solution = new();
var result = solution.AllPossibleFBT(7);
Console.WriteLine(result);


Console.WriteLine("Hello, World!");


public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
/// <summary>
/// This solution is not mine.
/// </summary>
public class Solution
{
    private readonly List<List<TreeNode>> _dp = new();

    public IList<TreeNode> AllPossibleFBT(int n)
    {
        for (var i = 0; i <= n; i++)
        {
            _dp.Add(new List<TreeNode>());
        }
        return Solve(n);
    }


    private List<TreeNode> Solve(int n)
    {
        if (_dp[n].Any())
        {
            return _dp[n];
        }
        if (n == 1)
        {
            return new List<TreeNode> { new TreeNode(0) };
        }
        var res = new List<TreeNode>();

        for (var i = 1; i < n; i += 2)
        {
            var left = Solve(i);
            var right = Solve(n - i - 1);

            foreach (var l in left)
            {
                foreach (var r in right)
                {
                    var root = new TreeNode(0)
                    {
                        left = l,
                        right = r
                    };
                    res.Add(root);
                }
            }
        }
        return _dp[n] = res;
    }
}