using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace RemoveLinkedListElements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);

            ListNode head1 = new ListNode(7);
            head1.next = new ListNode(7);
            head1.next.next = new ListNode(7);
            head1.next.next.next = new ListNode(7);


            Solution solution = new();
            var result = solution.RemoveElementsRecursive(head1, 7);
            Console.WriteLine();
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
        //It is not my solution
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummyNode = new ListNode(next: head);
            ListNode curr = head;
            ListNode prev = dummyNode;

            while (curr != null)
            {
                ListNode nexxt = curr.next;
                if (curr.val == val)
                {
                    prev.next = nexxt;
                }
                else
                {
                    prev = curr;
                }

                curr = nexxt;
            }

            return dummyNode.next;
        }

        public ListNode RemoveElementsRecursive(ListNode head, int val)
        {
            ListNode Recursive(ListNode cur)
            {
                if (cur == null)
                    return null;
                cur.next = Recursive(cur.next);
                if (cur.val == val)
                    return cur.next;
                return cur;
            }
            return Recursive(head);
        }
    }
}