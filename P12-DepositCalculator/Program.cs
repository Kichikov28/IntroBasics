using System;

namespace P12_DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double term = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double interest = (depositSum * percent) / 100;
            double interestPerMonth = interest / 12;
            double sum = depositSum + (term * interestPerMonth);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
