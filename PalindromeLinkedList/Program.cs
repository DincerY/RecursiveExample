using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace PalindromeLinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(2);
            listNode.next.next.next = new ListNode(1);

            Solution solution = new();
            solution.IsPalindrome(listNode);

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
        string stringVal = "";
        string reverseVal = "";

        public bool IsPalindrome(ListNode head)
        {
            ListNodeValueToString(head);

            void Recursion(ListNode head)
            {
                head = head.next;
                if (head != null)
                {
                    Recursion(head);
                }

                reverseVal += head?.val;

            }

            Recursion(head);
            reverseVal += head.val;

            if (stringVal == reverseVal)
            {
                return true;
            }
            return false;


        }

        private string ListNodeValueToString(ListNode head)
        {
            while (head != null)
            {
                stringVal += head.val;
                head = head.next;
            }

            return stringVal;
        }
    }
}