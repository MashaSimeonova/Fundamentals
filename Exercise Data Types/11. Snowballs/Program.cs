using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte snowballs = byte.Parse(Console.ReadLine());
            ushort bestSnowball = ushort.MinValue;
            ushort value = 0;
            short snow = 0;
            short time = 0;
            byte quality = 0;
            

            for (int i = 0; i < snowballs; i++)
            {
               ushort step = 1;
                value = 0;
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                
                for (int y = 0; y < snowballQuality; y++)
                {
                    step *= snowballSnow / snowballTime;
                }
                value = step;
                if (bestSnowball <= value)
                {
                    bestSnowball = value;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }
            Console.WriteLine($"{snow} : {time} = {bestSnowball} ({quality})");
        }
    }
}
