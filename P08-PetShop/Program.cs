using System;

namespace P08_PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogs = double.Parse(Console.ReadLine());
            double remainAnimals = double.Parse(Console.ReadLine());
            double forDogs = dogs * 2.5;
            double forRemain = remainAnimals * 4;
            double sum = forDogs + forRemain;
            Console.WriteLine($"{sum} lv.");

        }
    }
}
