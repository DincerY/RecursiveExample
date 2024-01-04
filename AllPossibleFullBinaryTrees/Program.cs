
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

public class Solution
{
    public IList<TreeNode> AllPossibleFBT(int n)
    {
        if (n % 2 == 0)
        {
            n = n - 1;
        }
        
        return null;
    }
    
}