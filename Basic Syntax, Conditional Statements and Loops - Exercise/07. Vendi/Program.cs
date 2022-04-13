using System;

namespace _07._Vendi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // "Nuts" with a price of 2.0
            // "Water" with a price of 0.7
            // "Crisps" with a price of 1.5
            // "Soda" with a price of 0.8
            // "Coke" with a price of 1.0
            string coin = Console.ReadLine();
            double balance = 0;
            const double NUTS = 2.0, WATER = 0.7, CRISPS = 1.5, SODA = 0.8, COKE = 1.0;
            bool notEnoughMoney = false;
            while (coin != "Start")
            {
                if (coin == "0.1" || coin == "0.2" || coin == "0.5" || coin == "1" || coin == "2")
                {
                    balance += double.Parse(coin);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                coin = Console.ReadLine();
            }
            coin = Console.ReadLine();
            while (coin != "End")
            {
                if (coin == "Nuts")
                {
                    if (balance >= NUTS)
                    {
                        Console.WriteLine($"Purchased nuts");
                        balance -= NUTS;
                    }
                    else notEnoughMoney = true;
                }
                else if (coin == "Water")
                {
                    if (balance >= WATER)
                    {
                        Console.WriteLine($"Purchased water");
                        balance -= WATER;
                    }
                    else notEnoughMoney = true;
                }
                else if (coin == "Crisps")
                {
                    if (balance >= CRISPS)
                    {
                        Console.WriteLine($"Purchased crisps");
                        balance -= CRISPS;
                    }
                    else notEnoughMoney = true;
                }
                else if (coin == "Soda")
                {
                    if (balance >= SODA)
                    {
                        Console.WriteLine($"Purchased soda");
                        balance -= SODA;
                    }
                    else notEnoughMoney = true;
                }
                else if (coin == "Coke")
                {
                    if (balance >= COKE)
                    {
                        Console.WriteLine($"Purchased coke");
                        balance -= COKE;
                    }
                    else notEnoughMoney = true;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                if (notEnoughMoney == true) Console.WriteLine("Sorry, not enough money");
                notEnoughMoney = false;
                coin = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:f2}");

        }
    }
}
