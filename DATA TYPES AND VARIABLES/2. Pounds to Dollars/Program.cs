using System;

namespace _2._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num =decimal.Parse(Console.ReadLine());
            decimal pound = num * (decimal)1.31;

            Console.WriteLine($"{pound:f3}" );
        }
    }
}
