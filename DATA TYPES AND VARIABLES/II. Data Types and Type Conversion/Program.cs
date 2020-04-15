using System;

namespace II._Data_Types_and_Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            days = Math.Floor(days);
            int hours = (int)days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
           
        }
    }
}
