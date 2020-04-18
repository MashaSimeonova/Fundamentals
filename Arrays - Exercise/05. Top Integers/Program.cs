using System;
using System.Linq;
namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < array.Length-1; i++)
            {
                int currentNumber = array[i];
                bool isTopInteger = true;

                for (int j = i+1; j < array.Length; j++)
                {
                    int nextNumber = array[j];

                    if (currentNumber<=nextNumber)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currentNumber+ " ");
                }
            }
            Console.Write(array[array.Length-1]);

        }
    }
}
