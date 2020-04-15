using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            int diggit = 0;
            bool special = false;
            for (int i = 1; i <= numbers; i++)
            {
                sum = 0;
                num = i;
                while (num != 0)
                {
                    diggit = num % 10;
                    sum += diggit;
                    num /= 10;
                }

                special = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, special);
                //JKSBDABFIFBQLFIU

            }

        }
    }
}
