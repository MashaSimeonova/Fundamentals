using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            float forOneSabre = float.Parse(Console.ReadLine());
            float forOneRobe = float.Parse(Console.ReadLine());
            float forOneBelt = float.Parse(Console.ReadLine());

            double numberOfSabers = Math.Ceiling(numberOfStudents + numberOfStudents * 0.10);
            float sabersPrice = (float)numberOfSabers * forOneSabre;

            float freeBelt = 0;
            if (numberOfStudents>=6)
            {
                freeBelt = numberOfStudents / 6 *forOneBelt;
            }

            float beltPrice = (numberOfStudents * forOneBelt) - freeBelt;
            float robePrice = numberOfStudents * forOneRobe;

            float totalExpense = beltPrice + robePrice + sabersPrice;

            if (totalExpense<=budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpense:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalExpense - budget):f2}lv more.");
            }
        }
    }
}
