﻿using System;

namespace _1._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            decimal kilometers = meters / (decimal)1000.0;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
