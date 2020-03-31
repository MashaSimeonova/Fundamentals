using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            string input = "";


            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            for (int j = 0; j < 3; j++)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in."); break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            if (input != password)
            {
                Console.WriteLine($"User {username} blocked!");
            }

        }
    }
}
