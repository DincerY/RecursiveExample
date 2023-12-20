using System.Runtime.InteropServices;

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
            solution.RemoveElements(head, 6);
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode result = head;
            while (head!=null && head.val == val)
            {
                head = head.next;
            }
            
            ListNode prev = head;
            while (head!=null)
            {
                if (head.val == val)
                {
                    prev.next = head.next;
                }

                head = head.next;

            }
            
            









            
            return result;
        }
    }
}