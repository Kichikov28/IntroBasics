using System;

namespace P09_YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double greening = meters * 7.61;
            double discount = greening * 0.18;
            double sum = greening - discount;
          
            Console.WriteLine($"The final price is: {sum:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2}");
        }
    }
}
