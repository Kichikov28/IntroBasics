using System;

namespace P33_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = null;
            string holiday = null;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    budget *= 0.3;
                }
                else if (season == "winter")
                {
                    budget *= 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    budget *= 0.4;
                }
                else if (season == "winter")
                {
                    budget *= 0.8;
                }
            }
            else
            {
                destination = "Europe";
                budget *= 0.9;

            }
            if (season == "summer")
            {
                holiday = "Camp";
            }
            if (season=="summer"&&destination=="Europe")
            {
                holiday = "Hotel";
            }
            else if (season == "winter")
            {
                holiday = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holiday} - {budget:f2}");


        }
    }
}
