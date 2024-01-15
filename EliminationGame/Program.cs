using System.Net.Security;

Solution solution = new Solution();
solution.LastRemaining(100000000);
Console.WriteLine("Hello, World!");



public class Solution {
    public int LastRemaining(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        int[] arr = CreateArr(n);
        int returned = 0;

        void Recursion(IEnumerable<int> reverseArr)
        {
            var result = new List<int>();
            if (reverseArr.Count() > 1)
            {
                for (int i = 0; i < reverseArr.Count()-1; i+=2)
                {
                    result.Add(reverseArr.Skip(i+1).Take(1).Single());
                    
                }

                result.Reverse(0, result.Count);
                Recursion(result);
                if (result.Count == 1)
                {
                    returned = result[0];
                }
            }
        }
        
        Recursion(arr);
        return returned;
    }

    private int[] CreateArr(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }
        return arr;
    }
}