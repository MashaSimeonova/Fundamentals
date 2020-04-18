using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sum += people;
                Console.Write(people + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
