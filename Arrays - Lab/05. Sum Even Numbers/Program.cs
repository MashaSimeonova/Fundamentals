using System;
using System.Linq;
namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] evenSum = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < evenSum.Length; i++)
            {
                int currentNumber = evenSum[i];

                if (currentNumber%2 == 0)
                {
                    sum+=currentNumber;
                }
            }
            Console.WriteLine(sum); 
        }
    }
}
