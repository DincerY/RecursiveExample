using System.Diagnostics;

namespace PowerOfThree
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.IsPowerOfThreeRecursion(0);
            solution.IsPowerOfThreeWhile(0);
        }
    }


    public class Solution
    {
        public bool IsPowerOfThreeRecursion(int n)
        {
            if (n == 1)
            {
                return true;
            }
            if (n % 3 != 0 || n == 0)
            {
                return false;
            }

            return IsPowerOfThreeRecursion(n / 3);
        }

        public bool IsPowerOfThreeWhile(int n)
        {
            while (n % 3 == 0 && n != 0)
            {
                n = n / 3;
            }

            if (n == 1)
            {
                return true;
            }

            return false;
        }
        
    }
}