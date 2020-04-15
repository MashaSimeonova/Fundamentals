using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBeers = int.Parse(Console.ReadLine());
            decimal volume = 0;
            decimal biggestVolum = decimal.MinValue;
            string beer = "";
            


            for (int i = 0; i < numberOfBeers; i++)
            {
                string typeBeer = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                float height = float.Parse(Console.ReadLine());

                volume = (decimal)3.14 * (decimal)(radius * radius) * (decimal)height;

                if (volume>=biggestVolum)
                {
                    
                    biggestVolum = volume;
                    beer = typeBeer;
                }
            }
            
                Console.WriteLine(beer);
           
            
        }
    }
}
