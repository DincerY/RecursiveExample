using System;
using System.Collections.Generic;

namespace NumberOfDigitOne
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.CountDigitOneWithFor(824883294);
            Console.WriteLine(a);
        }
    }
    
    
    public class Solution {

        public int CountDigitOne(int n)
        {




            return 0;
        }

        
        public int CountDigitOneWithFor(int n)
        {
            //Add memoization
            Dictionary<string, int> cache = new();  
            int total = 0;
            void Recursion(int a)
            {
                if (a == 0)
                {
                    return;
                }

                if (a%10 == 1)
                {
                    total++;
                }
                Recursion(a/10);
            }
            
            for (int i = n; i > 0; i--)
            {
                Recursion(i);
            }
            
            return total;
        }
    }
}