using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace PowerOfNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.MyPow(2.00000, -2);
        }
    }

    public class Solution
    {
        public double MyPow(double x, int n)
        {
            double res = 0;

            double Recursion(int newN)
            {
                if (newN == 0)
                {
                    return 1;
                }

                res = Recursion(newN / 2);
                res = res * res;
                if (newN % 2 == 0)
                {
                    return res;
                }
                else
                {
                    return res * x;
                }
            }

            return n < 0 ? 1 / Recursion(n) : Recursion(n);
        }
    }
}