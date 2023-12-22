using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

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
            Stack<string> stack = new();
            for (int i = 0; i < s.Length; i++)
            {
                string a = "";
                string power = "";
                int j = i;
                if (s[i] != ']')
                {
                    stack.Push(s[i].ToString());
                }
                else
                {
                    
                    while (s[j] != '[')
                    {
                        if (stack.Peek() == "[")
                        {
                            stack.Pop();
                        }
                        else
                        {
                            a += stack.Pop();
                        }

                        j--;
                    }

                    
                    while (j > 0)
                    {
                        power += stack.Pop();
                        j--;
                    }
                    
                    stack.Push(string.Concat(Enumerable.Repeat(a, int.Parse(power))));
                }
            }


            return "";
        }
    }
}