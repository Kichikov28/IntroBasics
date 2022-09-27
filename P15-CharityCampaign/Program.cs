using System;

namespace P15_CharityCampaign
{
    
    class Program
    {
        private const int cake = 45;
        private const double waffle = 5.80;
        private const double pancake = 3.20;
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sugarWorkers= int.Parse(Console.ReadLine());
            int cakes= int.Parse(Console.ReadLine());
            int waffles= int.Parse(Console.ReadLine());
            int pancakes= int.Parse(Console.ReadLine());

            double sumCakes = cake * cakes;
            double sumWaffles = waffle * waffles;
            double sumPancakes = pancake * pancakes;

            double sumPerDay = (sumCakes + sumWaffles + sumPancakes) * sugarWorkers;
            double campaign = sumPerDay * days;
            double cost = campaign - (campaign / 8);
            Console.WriteLine($"{cost:f2}");
        }
    }
}
