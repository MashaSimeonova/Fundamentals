using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToPour = int.Parse(Console.ReadLine());
            int littersIntank = 0;
            int tankCapacity = 255;

            for (int i = 0; i < timesToPour; i++)
            {
                int waterFill = int.Parse(Console.ReadLine());

                if (littersIntank+waterFill<=tankCapacity)
                {
                    littersIntank += waterFill;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
               
            }
            Console.WriteLine(littersIntank);

        }
    }
}
