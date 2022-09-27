using System;

namespace P03_EnergyBooster
{
    
    class Program
    {
        private const int small = 2;
        private const int big = 5;
        private const double watermelonSmall = 56;
        private const double watermelonBig = 28.70;
        private const double MangoSmall = 36.66;
        private const double MangoBig = 19.60;
        private const double PineappleSmall = 42.10;
        private const double PineappleBig = 24.80;
        private const double RaspberrySmall = 20;
        private const double RaspberryBig = 15.20;
        static void Main()
        {
            string fruit = Console.ReadLine();
            string sizeOfSet = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double amount = 1;
            double discount = 0.85;
            double discountover1000 = 0.5;
            
            if (fruit=="Watermelon")
            {
                if (sizeOfSet=="small")
                {
                     amount = small * watermelonSmall * sets;
                    if (amount >= 400 && amount <= 1000){ amount *= discount; }
                    else  { amount *= discountover1000; }
                }
                else if (sizeOfSet=="big")
                { amount = big * watermelonBig * sets;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
                
            }
            if (fruit == "Mango")
            {
                if (sizeOfSet == "small")
                {
                    amount = small * MangoSmall * sets;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
                else if (sizeOfSet == "big")
                {
                    amount = big * MangoBig * sets;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
            }
            if (fruit == "Pineapple")
            {
                if (sizeOfSet == "small")
                {
                    amount = small * PineappleSmall ;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
                else if (sizeOfSet == "big")
                {
                    amount = big * PineappleBig * sets;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
            }
            if (fruit == "Raspberry")
            {
                if (sizeOfSet == "small")
                {
                    amount = small * RaspberrySmall * sets;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
                else if (sizeOfSet == "big")
                {
                    amount = big * RaspberryBig * sets;
                    if (amount >= 400 && amount <= 1000) { amount *= discount; }
                    else { amount *= discountover1000; }
                }
            }
            Console.WriteLine($"{amount:f2} lv.");
        }

        
    }
}
