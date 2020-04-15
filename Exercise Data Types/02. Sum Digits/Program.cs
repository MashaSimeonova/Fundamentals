using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberTostring = number.ToString();
            int currentDiggit = 0;
            int sum = 0;

            for (int i = 0; i < numberTostring.Length; i++)
            {
                currentDiggit = number % 10;
                sum += currentDiggit;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
