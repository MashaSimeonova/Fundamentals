using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    for (int j = 0; j < number; j++)
            //    {
            //        for (int k = 0; k < number; k++)
            //        {
            //            Console.WriteLine($"{(char)(i+'a')}{(char)(j+'a')}{(char)(k+'a')}");
            //        }
            //    }
            //}
            // Second solution
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < number + 'a'; i++)
            {
                for (char j = 'a' ; j < number + 'a'; j++)
                {
                    for (char k = 'a'; k < number + 'a'; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
