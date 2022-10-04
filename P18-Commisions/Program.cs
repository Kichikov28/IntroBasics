using System;

namespace P18_Commisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            double commision = 0;
            if (sells>=0&&sells<=500)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 5;
                        break;
                    case "Varna":
                        commision = 4.5;
                        break;
                    case "Plovdiv":
                        commision = 5.5;
                        break;
                }
                Console.WriteLine($"{(commision / 100) * sells:f2}");
            }
            if (sells > 500 && sells <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 7;
                        break;
                    case "Varna":
                        commision = 7.5;
                        break;
                    case "Plovdiv":
                        commision = 8;
                        break;
                }
                Console.WriteLine($"{(commision / 100) * sells:f2}");
            }
            if (sells >1000 && sells <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 8;
                        break;
                    case "Varna":
                        commision = 10;
                        break;
                    case "Plovdiv":
                        commision = 12;
                        break;
                }
                Console.WriteLine($"{(commision / 100) * sells:f2}");
            }
            if (sells >10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 12;
                        break;
                    case "Varna":
                        commision = 13;
                        break;
                    case "Plovdiv":
                        commision = 14.5;
                        break;
                }
                Console.WriteLine($"{(commision / 100) * sells:f2}");
            }
            if (sells<=0)
            {
                Console.WriteLine("error");
            }
          

        }
    }
}
