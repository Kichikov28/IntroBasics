using System;

namespace P35_HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;
            double sumStudio = 0;
            double sumApartment =0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                apartment = 65;
                if (nights > 14)
                {
                    studio= studio-studio*0.3;
                    sumStudio = studio * nights;
                }
                if (nights>7)
                {
                    studio *= 0.95;
                    sumStudio = studio * nights;
                }
                if (nights>14)
                {
                    apartment *= 0.9;
                    sumApartment = apartment * nights;
                }
                sumStudio = studio * nights;
                sumApartment = apartment * nights;
            }
            if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (nights>14)
                {
                    studio *= 0.8; 
                    sumStudio = studio * nights;
                }
                if (nights > 14)
                {
                    apartment *= 0.9;
                    sumApartment  = apartment * nights;
                }
                sumStudio = studio * nights;
                sumApartment = apartment * nights;
            }
            if (month == "July" || month == "August")
            {
                studio = 76;
                apartment = 77;
                sumStudio = studio * nights;
                if (nights > 14)
                {
                    apartment *= 0.9;
                    sumApartment = apartment * nights;
                }
                sumApartment = apartment * nights;
            }
            Console.WriteLine($"Apartment: {sumApartment:f2} lv.");
            Console.WriteLine($"Studio: {sumStudio:f2} lv.");

        }
    }
}
