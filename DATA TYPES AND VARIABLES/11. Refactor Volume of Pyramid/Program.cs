﻿using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            //Console.Write(" Width: ");
            double width = double.Parse(Console.ReadLine());
           // Console.Write(" Height: ");
            double height = double.Parse(Console.ReadLine());
            double pyramidVolume = (length * width * height) / 3;
                 Console.WriteLine($"Length: Width: Height: Pyramid Volume: {pyramidVolume:f2}");

        }
    }
}
