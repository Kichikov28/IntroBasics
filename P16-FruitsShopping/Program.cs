using System;

namespace P16_FruitsShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberries = double.Parse(Console.ReadLine());
            double bananas= double.Parse(Console.ReadLine());
            double oranges= double.Parse(Console.ReadLine());
            double raspberries= double.Parse(Console.ReadLine());
            double strawberriesinKg= double.Parse(Console.ReadLine());

            double raspberriesPrice = strawberries / 2;
            double orangesPrice = raspberriesPrice * 0.6;
            double bananasPrice = raspberriesPrice * 0.2;

            double sumRaspberries = raspberries * raspberriesPrice;
            double sumOranges = oranges * orangesPrice;
            double sumBananas = bananas * bananasPrice;
            double sumStrawberries = strawberries * strawberriesinKg;

            double sumAll = sumRaspberries + sumOranges + sumBananas + sumStrawberries;
            Console.WriteLine($"{sumAll:f2}");

        }
    }
}
