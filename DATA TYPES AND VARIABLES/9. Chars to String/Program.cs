using System;

namespace _9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstDiggit = char.Parse(Console.ReadLine());
            char secondDiggit = char.Parse(Console.ReadLine());
            char thirdDiggit = char.Parse(Console.ReadLine());

            char[] chars = { firstDiggit, secondDiggit, thirdDiggit };
            string s = new string(chars);
            Console.WriteLine(s);
        }
    }
}
