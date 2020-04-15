using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfDiggits = byte.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numberOfDiggits; i++)
            {
                char diggit = char.Parse(Console.ReadLine());
                int diggitNumber = (int)diggit;
                sum += diggitNumber;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
