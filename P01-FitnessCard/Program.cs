using System;

namespace P01_FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double amount = 0;
            if (sex == 'm')
            {
                if (sport == "Gym")
                {
                    amount += 42;
                    if (age<=19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum >amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Boxing")
                {
                    amount+= 41;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Yoga")
                {
                    amount += 45;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Zumba")
                {
                    amount += 34;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Dances")
                {
                    amount += 51;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Pilates")
                {
                    amount += 39;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
            }
            else if (sex == 'f')
            {
                if (sport == "Gym")
                {
                    amount += 35;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Boxing")
                {
                    amount += 37;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Yoga")
                {
                    amount += 42;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Zumba")
                {
                    amount += 31;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Dances")
                {
                    amount += 53;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
                else if (sport == "Pilates")
                {
                    amount += 37;
                    if (age <= 19)
                    {
                        amount = amount * 0.8;
                    }
                    if (sum > amount)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(sum - amount):f2} more."
);
                    }
                }
            }
        }
    }
}
