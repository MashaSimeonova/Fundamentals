using System;

namespace Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];

            names[2] = "Ivan";
            names[9] = "Anna";
            names[0] = "Masha";

            Console.WriteLine(names[9]);

            string nineNames = names[9];

            // za da widim kolko ni e masiwyt/ Console.WriteLine(names.Length);

            int[] numbers = new int[50];

            numbers[5] = 125;

            // можем да четем дължина на масив от конзолата!
            // int length = int.Parse(Console.ReadLine());

           //  int[] something = new int[length];

            // чрез for цикъл можем да запълваме масив/Arrays

            int[] fill = new int[10];

            for (int i = 0; i < fill.Length; i++)
            {
                fill[i] = i+1;
                Console.WriteLine(fill[i]);
            }


            // мога да записвам в string чрез командата string.Join масиви от всякакъв тип.

            int[] join = new int[5];

            join[1] = 100;
            join[3] = 1000;

            string result = string.Join(",", join);
            Console.WriteLine(result);

            //  Не можем да клонираме масиви. Те винаги си влияят и вземат последните посочени стойности.
            // Можем обаче , отново чрез for цикъл да вземем стойностите от един  масив и да ги презапишем в друг
            // Пример:

            int[] firstArray = new int[6];

            firstArray[1] = 3;
            firstArray[3] = 5;
            firstArray[5] = 7;

            int[] secondArray = new int[8];

            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
                Console.WriteLine(secondArray[i]);
            }
            // винаги даваме length на по-малкият по дължина масив, инак излиза от диапазона)

            // ПО-ЛЕСЕН СИНТАКСИС ЗА ЗАПИСВАНЕ НА МАСИВИ!

            int[] easy = {1,2,3,4,5 };

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }

    }
}
