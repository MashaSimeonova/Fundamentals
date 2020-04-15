using System;

namespace _5._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            int curentDiggit = 0;

            for (int i = 1; i <=num; i++)
            {

                sum = 0;
                number = i;
                while (number!=0)
                {
                    curentDiggit = number % 10;
                    sum += curentDiggit;

                    number /= 10;
                }
                if (sum == 5 || sum ==7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
