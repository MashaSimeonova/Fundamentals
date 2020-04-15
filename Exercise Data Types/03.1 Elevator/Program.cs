using System;

namespace _03._1_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPeople = int.Parse(Console.ReadLine());
            int peopleAllowed = int.Parse(Console.ReadLine());

            int courses = allPeople / peopleAllowed;
            int extraCourse = allPeople % peopleAllowed;

            if (extraCourse!=0)
            {
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
