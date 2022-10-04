using System;

namespace P13_WorkingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hour >= 10 && hour <= 18 && day == "Monday")
            {
                Console.WriteLine("open");
            }
            else if (hour >= 10 && hour <= 18 && day == "Tuesday")
            {
                Console.WriteLine("open");
            }
            else if (hour >= 10 && hour <= 18 && day == "Wednesday")
            {
                Console.WriteLine("open");
            }
            else if (hour >= 10 && hour <= 18 && day == "Thursday")
            {
                Console.WriteLine("open");
            }
            else if (hour >= 10 && hour <= 18 && day == "Friday")
            {
                Console.WriteLine("open");
            }
            else if (hour >= 10 && hour <= 18 && day == "Saturday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
