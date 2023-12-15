using System.Collections.Generic;

namespace FibonacciNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a =solution.Fib(6);
        }
    }


    public class Solution
    {
        private Dictionary<int, int> fibCache = new Dictionary<int, int>();

        public int Fib(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            if (n == 0)
            {
                return 0;
            }
            
            if (fibCache.ContainsKey(n))
            {
                return fibCache[n];
            }

            fibCache[n] = Fib(n - 1) 
                          + 
                          Fib(n - 2);
            return fibCache[n];
        }
    }
}