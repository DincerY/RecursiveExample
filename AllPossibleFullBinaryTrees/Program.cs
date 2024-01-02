// See https://aka.ms/new-console-template for more information

Solution solution = new();
solution.AllPossibleFBT(7);

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
        List<TreeNode> result = new();
        TreeNode head = new TreeNode();
        int total = 1;

        void Recusion(TreeNode node)
        {
            if (total + 2 <= n)
            {
                total += 2;
                node.left = new();
                node.right = new();
                //right
                Recusion(node.right);
                result.Add(node);
                //left
                Recusion(node.left);
                result.Add(node);
            }
        }
        Recusion(head);
        return result;
    }
}