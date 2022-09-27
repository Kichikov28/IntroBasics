using System;

namespace P14_Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePice = rent * 0.2;
            double drinks = cakePice - cakePice * 0.45;
            double animator = rent / 3;
            double neededSum = rent + drinks + cakePice + animator;
            Console.WriteLine($"{neededSum:f2}");
        }
    }
}
