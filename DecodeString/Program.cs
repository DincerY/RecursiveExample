using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace DecodeString
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            //   3[a]2[bc]
            var a = solution.DecodeString("3[a2[c]]");
            Console.WriteLine(a);
        }
    }


    public class Solution
    {
        public string DecodeString(string s)
        {
            Stack<object> stack = new Stack<object>();
            int i = 0;

            while (i < s.Length)
            {
                if (char.IsDigit(s[i]))
                {
                    int count = 0;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        count = count * 10 + (s[i] - '0');
                        i++;
                    }
                    stack.Push(count);
                }
                else if (s[i] == '[')
                {
                    stack.Push(s[i]);
                    i++;
                }
                else if (s[i] == ']')
                {
                    StringBuilder substr = new StringBuilder();
                    while (stack.Peek() is string)
                    {
                        substr.Insert(0, stack.Pop() as string);
                    }
                    stack.Pop(); // Remove '[' from the stack
                    int repeatCount = (int)stack.Pop();

                    StringBuilder repeatedSubstring = new StringBuilder();
                    for (int j = 0; j < repeatCount; j++)
                    {
                        repeatedSubstring.Append(substr);
                    }

                    stack.Push(repeatedSubstring.ToString());
                    i++;
                }
                else
                {
                    StringBuilder substr = new StringBuilder();
                    while (i < s.Length && char.IsLetter(s[i]))
                    {
                        substr.Append(s[i]);
                        i++;
                    }
                    stack.Push(substr.ToString());
                }
            }

            StringBuilder result = new StringBuilder();
            while (stack.Count > 0)
            {
                result.Insert(0, stack.Pop() as string);
            }

            return result.ToString();
        }
    }
}