using System;

namespace P15_FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruitOrVegetable = Console.ReadLine();
            if (fruitOrVegetable=="banana"||fruitOrVegetable=="apple"||fruitOrVegetable=="kiwi"||fruitOrVegetable=="cherry"||fruitOrVegetable=="lemon"||fruitOrVegetable=="grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (fruitOrVegetable == "tomato" || fruitOrVegetable == "pepper" || fruitOrVegetable == "cucumber" || fruitOrVegetable == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
