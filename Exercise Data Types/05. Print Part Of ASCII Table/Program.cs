﻿using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <=secondNumber; i++)
            {
                char diggit = (char)i;
                Console.Write($"{diggit} ");
            }

        }
    }
}
