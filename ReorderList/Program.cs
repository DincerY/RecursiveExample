using System;

namespace ReorderList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode head = new(1, new(2, new(3, new(4, new(5, new(6, new(7, new(8))))))));
            ListNode head1 = new ListNode(1);


            Solution solution = new();
            solution.ReorderList(head);
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
        public void ReorderList(ListNode head)
        {
            ListNode Recursion(ListNode node)
            {
                ListNode prev = null;
                if (node.next == null)
                {
                    return node;
                }
                if (node.next.next == null)
                {
                    var a = node.next;
                    node.next = null;
                    prev = head.next;
                    head.next = a;
                    a.next = prev;
                    return prev;
                }
                ListNode pr = Recursion(node.next);
                if (pr?.next == null)
                {
                    return pr;
                }
                ListNode prr = null;
                ListNode b = node.next;
                node.next = null;
                prr = pr.next;
                pr.next = b;
                b.next = prr;
                return prr;
            }
            Recursion(head);
        }
    }
}