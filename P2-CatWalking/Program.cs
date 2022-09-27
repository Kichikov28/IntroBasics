using System;

namespace P2_CatWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int countWalks = int.Parse(Console.ReadLine());
            int earnedCalories = int.Parse(Console.ReadLine());

            int walkDone = minutes * countWalks;
            int burnedCalories = walkDone * 5;
            double calories = 0.5 * earnedCalories;
            if (burnedCalories>=calories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnedCalories}.");
            }
        }
    }
}
