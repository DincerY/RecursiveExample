using System.Net.Security;

Solution1 solution = new Solution1();
solution.LastRemaining(10);
Console.WriteLine("Hello, World!");

#region Solution

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


#endregion

class Solution1
{
    /// <summary>
    /// Bu kodu tane tane açıklamak istiyorum normalde ben bu sorunu array ile çözdüm fakat yoktan yere bellek işgal ettim
    /// sonra bir tane videoda bu çözüme denk geldim. Reminder dediğimiz kısım bizim kalan elemanlarımızın sayısı while her
    /// döndüğünde yarınya bölünüyor çünkü elenaları baştan birer atlayarak elersek eleman sayısı yarınya düşer.
    /// Left değişkeni elemeye soldan mu sağdan mı başlanacağını belirtir burayı anlamak biraz zor bende zor anladım çünkü
    /// Leftin olayını anlamak için biraz farklı düşünmeliyiz aslında left head in değişip değişmeyeceğine karar veriyor
    /// onuda şöyle yapıyor. Mesela sağdan eleme yapılacak yani left false ve elimizde 4 tane eleman var {2,4,6,8} bu elemanlar
    /// için sağdan başlanırsa head değişmeyecek çünkü geriye {2,4} kalacak işte left bunu belli ediyor.
    /// Aslında koddaki if kontrolüde tam olarak buna bakıyor sadece if gerçekleşirse head in değeri değişiyor.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public int LastRemaining(int n)
    {
        int reminder = n;
        bool left = true;
        int head = 1;
        int step = 1;
        while (reminder > 1)
        {
            if (left || reminder % 2 == 1)
            {
                head += step;
            }

            left = !left;
            step *= 2;
            reminder /= 2;
        }
        
        
        return head;
    }
}