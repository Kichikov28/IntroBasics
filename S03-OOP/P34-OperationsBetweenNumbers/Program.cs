using System;

namespace P34_OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            double result = 0;
            string oddOrEven = null;
           

            if (symbol=="+")
            {
                result = n1 + n2;
                if (result % 2 == 0)
                {  oddOrEven = "even";}else { oddOrEven = "odd"; }
                Console.WriteLine($"{n1} {symbol} {n2} = {result} - {oddOrEven}");
            }
            if (symbol=="-")
            {
                result = n1 - n2; if (result % 2 == 0)
                {  oddOrEven = "even"; }
                else
                { oddOrEven = "odd"; }
                Console.WriteLine($"{n1} {symbol} {n2} = {result} - {oddOrEven}");
            }
            if (symbol=="*")
            {
                result = n1 * n2; if (result % 2 == 0)
                { oddOrEven = "even";   }
                else
                {  oddOrEven = "odd"; }
                Console.WriteLine($"{n1} {symbol} {n2} = {result} - {oddOrEven}");
            }
            if (symbol=="/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }

                if(n2!=0)
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} {symbol} {n2} = {result:f2}");

                }
                if (result % 2 == 0)
                { oddOrEven = "even"; }
                else
                { oddOrEven = "odd"; }
                
            }
            if (symbol=="%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                if (n2 != 0)
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {symbol} {n2} = {result}");

                }
                 if (result % 2 == 0)
                { oddOrEven = "even";}
                else
                {  oddOrEven = "odd"; }
                
            }
           



        }
    }
}
