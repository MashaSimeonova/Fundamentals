using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headSetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardtPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
            int counterHeadSet = 0;
            int counterMouse = 0;
            int counterKeyboards = 0;
            int counterDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    counterHeadSet += 1;
                }
                if (i % 3 == 0)
                {
                    counterMouse += 1;
                }
                if (i % 6 == 0)
                {
                    counterKeyboards += 1;
                }
                if (counterKeyboards % 2 == 0 && counterKeyboards != 0 && i%6 == 0)
                {
                    counterDisplay += 1;
                }
            }
            float totalPrice = (counterDisplay*displayPrice) + (counterHeadSet*headSetPrice) + (counterKeyboards*keyboardtPrice) + (counterMouse*mousePrice);

            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
