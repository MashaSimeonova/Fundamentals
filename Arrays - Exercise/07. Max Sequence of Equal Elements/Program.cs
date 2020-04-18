using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int numberSequance = array[0];
            int maxCounter = 1;
            int currentCounter = 1;


            for (int i = 1; i < array.Length; i++)
            {
                int previusNumber = array[i - 1];
                int currentNumber = array[i];

                if (previusNumber==currentNumber)
                {
                    currentCounter++;

                    if (currentCounter > maxCounter)
                    {
                        maxCounter = currentCounter;
                        numberSequance = currentNumber;
                    }
                }
                else
                {
                    currentCounter = 1;
                }
            }

            for (int j = 0; j < maxCounter; j++)
            {
                Console.Write(numberSequance+ " ");
            }
            Console.WriteLine();
        }
    }
}
