using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double counterMoneyIn = 0;

            while (command != "Start")
            {
                double money = double.Parse(command);

                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1.0 || money == 2.0)
                {
                    counterMoneyIn += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double productPrice = 0;
            while (product!="End")
            {
               
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        
                        if (counterMoneyIn >= productPrice)
                        {
                            counterMoneyIn -= productPrice;
                            Console.WriteLine($"Purchased nuts");
                            
                        }
                        else
                        {
                            
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        productPrice = 0.7;
                        if (counterMoneyIn >= productPrice)
                        {
                            counterMoneyIn -= productPrice;
                            Console.WriteLine($"Purchased water");

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");
                        }

                        break;
                    case "Crisps":
                        
                        productPrice = 1.5;
                        if (counterMoneyIn >= productPrice)
                        {
                            counterMoneyIn -= productPrice;
                            Console.WriteLine($"Purchased crisps");

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        if (counterMoneyIn >= productPrice)
                        {
                            counterMoneyIn -= productPrice;
                            Console.WriteLine($"Purchased soda");

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        if (counterMoneyIn >= productPrice)
                        {
                            counterMoneyIn -= productPrice;
                            Console.WriteLine($"Purchased coke");

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                


                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {counterMoneyIn:f2}");
        }
    }
}
