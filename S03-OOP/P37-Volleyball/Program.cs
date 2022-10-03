using System;

namespace P37_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double sum = 0;

            double weekendsInSofia = (48 - h) * (3 / 4);
            double gamesInSofia = p * 2 / 3;
            sum = weekendsInSofia + h + gamesInSofia;
            if (year == "leap")
            {
                sum += 0.15 * sum;
            }

            Console.WriteLine(Math.Floor(sum));



        }
    }
}
