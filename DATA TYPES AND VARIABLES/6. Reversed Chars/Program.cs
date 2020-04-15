using System;

namespace _6._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstDiggit = char.Parse(Console.ReadLine());
            char secondDiggit = char.Parse(Console.ReadLine());
            char thirdDiggit = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdDiggit} {secondDiggit} {firstDiggit}");
        }
    }
}
