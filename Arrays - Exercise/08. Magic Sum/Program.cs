using System;
using System.Linq;
namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrey = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int specialNumber = int.Parse(Console.ReadLine());
            int currentSum = 0;

            for (int i = 0; i < arrey.Length; i++)
            {
                int currentNumber = arrey[i];

                for (int j = i+1; j < arrey.Length; j++)
                {
                    currentSum = currentNumber + arrey[j];
                    if (currentSum == specialNumber)

                    {
                        Console.WriteLine($"{currentNumber} {arrey[j]}");
                    }
                }
            }
        }
    }
}
