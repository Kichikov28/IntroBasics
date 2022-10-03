using System;

namespace P36_OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int arrived = int.Parse(Console.ReadLine());
            int minutesarrived = int.Parse(Console.ReadLine());
            if (hour<=arrived||minutes<minutesarrived)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{Math.Abs(minutes-minutesarrived)} minutes after the start");
            }
            if (hour >= arrived || minutes > minutesarrived)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{Math.Abs(minutes - minutesarrived)} minutes after the start");
            }






        }
    }
}
