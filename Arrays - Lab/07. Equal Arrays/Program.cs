using System;
using System.Linq;
namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int sum2 = 0;
            
               for (int i = 0; i < firstArr.Length; i++)
                {
                    int currentNumber = firstArr[i];
                    sum += currentNumber;
                    if (firstArr[i]!=secondArr[i])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");break;
                    }
                   
                }
            for (int i = 0; i < secondArr.Length; i++)
            {
                int currentNumber = secondArr[i];
                sum2 += currentNumber;
            }

            if (sum==sum2)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

            
            
        }
    }
}
