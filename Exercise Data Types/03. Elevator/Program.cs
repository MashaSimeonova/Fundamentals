using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPersons = int.Parse(Console.ReadLine());
            int personsAllowed = int.Parse(Console.ReadLine());
            int courses = 0;
            int peopleLeft = allPersons;
            if (allPersons<=personsAllowed)
            {
                Console.WriteLine("1");
            }
            else
            {
                while (peopleLeft>=0)
                {
                    peopleLeft -= personsAllowed;
                    courses += 1;
                }
                Console.WriteLine(courses);
            }
        }
    }
}
