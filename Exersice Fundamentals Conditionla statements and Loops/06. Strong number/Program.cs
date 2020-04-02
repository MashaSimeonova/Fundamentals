using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNumber = number;
            int sum = 0;

            while (copyNumber != 0)
            {
                int currentDiggit = copyNumber % 10;
                int currentFactoriel = 1;

                for (int i = 1; i <=currentDiggit; i++)
                {
                    currentFactoriel *= i;

                }

                sum += currentFactoriel;

                copyNumber /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
