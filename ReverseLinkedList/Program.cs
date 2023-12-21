namespace ReverseLinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);


            Solution solution = new();
            solution.ReverseList(head);
        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode result = null;
            ListNode temp = null;
            void Recursion(ListNode node)
            {
                if (node == null)
                {
                    return;
                }
                Recursion(node.next);
                if (result == null)
                {
                    result = new(node.val);
                    temp = result;
                }
                else
                {
                    result.next = new ListNode(node.val);
                    result = result.next;
                }
            }
            Recursion(head);
            return temp;
        }
    }
}