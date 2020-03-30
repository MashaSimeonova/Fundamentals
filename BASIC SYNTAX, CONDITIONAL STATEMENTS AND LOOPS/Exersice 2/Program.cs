using System;

namespace Exersice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // time after 30 min;

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minutesPlus30 = minutes + 30;

            if (minutesPlus30>=60)
            {
                hour += 1;
                minutesPlus30 = minutesPlus30 % 60;
                
            }

            if (hour==24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutesPlus30:d2}");

        }
        
    }
}
