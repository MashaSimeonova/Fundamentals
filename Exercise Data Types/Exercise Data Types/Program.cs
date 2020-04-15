using System;

namespace Exercise_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourtNumber = int.Parse(Console.ReadLine());
            long firstSum = firstNumber + secondNumber;
            long secondSum = firstSum / thirdNumber;
            long thirdSum = secondSum * fourtNumber;
            Console.WriteLine(thirdSum);
        }
    }
}
