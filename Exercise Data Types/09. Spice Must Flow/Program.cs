using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYeild = int.Parse(Console.ReadLine());
            short workers = 26;
            int finalYeild = 0;
            byte dayCounter = 0;

            while (startYeild>=100)
            {
                finalYeild += startYeild;
                finalYeild -= workers;
                startYeild -= 10;
                dayCounter += 1;
                
            }
            if (finalYeild!=0)
            {
                finalYeild -= 26;
            }
           
            Console.WriteLine(dayCounter);
            Console.WriteLine(finalYeild);

        }
    }
}
