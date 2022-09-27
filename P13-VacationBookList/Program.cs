using System;

namespace P13_VacationBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            double pages = double.Parse(Console.ReadLine());
            double pagerPerHour = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double time = pages / pagerPerHour;
            double timeperDay = time / days;
            Console.WriteLine($"{timeperDay:f2}");
        }
    }
}
