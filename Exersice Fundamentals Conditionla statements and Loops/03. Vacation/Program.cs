using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberOfPeople = decimal.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            decimal finalPrice = 0;

            if (typeOfGroup == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        price = (decimal)8.45;
                        break;
                    case "Saturday":
                        price = 9.80m;
                        break;
                    case "Sunday":
                        price = 10.46m;
                        break;

                    default:
                        break;
                }
            }
            else if (typeOfGroup == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        price = 10.90m;
                        break;
                    case "Saturday":
                        price = 15.60m;
                        break;
                    case "Sunday":
                        price = 16.00m;
                        break;

                    default:
                        break;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        price = 15.0m;
                        break;
                    case "Saturday":
                        price = 20.0m;
                        break;
                    case "Sunday":
                        price = 22.50m;
                        break;

                    default:
                        break;
                }
            }
           
            finalPrice = price * numberOfPeople;

            if (typeOfGroup == "Students" && numberOfPeople >= 30 && numberOfPeople < 100)
            {
                
                finalPrice = finalPrice * 0.85m;
            }
            if (typeOfGroup== "Business" && numberOfPeople >= 100)
            {

                finalPrice = price * numberOfPeople - (price*10);
            }
            if (typeOfGroup == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                
                finalPrice = finalPrice * 0.95m;
            }

            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}
