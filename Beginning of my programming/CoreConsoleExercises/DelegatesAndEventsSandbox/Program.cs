using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesAndEventsSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var eating = new EatingProducts();
            var alerter = new ConsoleAlerter();

            eating.AddingProduct += alerter.AddingProductAlert;
            eating.AddedProduct += alerter.AddedProductAlert;

            while (true)
            {
                Console.WriteLine("options:     -add [name] [ammount]    -showlist      -nutrients [name]    -nutrientslist");
                var input = Console.ReadLine().ToLower().Split();

                switch (input[0])
                {
                    case "-add":
                        if (input.Count() != 3 || String.IsNullOrEmpty(input[1]) || String.IsNullOrEmpty(input[2])) break;
                        eating.AddProductEaten(input[1], Convert.ToDouble(input[2]));
                        break;
                    case "-showlist":
                        eating.PrintOutEatenList();
                        break;
                    case "-nutrients":
                        if (input.Count() != 2 || String.IsNullOrEmpty(input[1])) break;
                        eating.PrintOutEatenNutrients(input[1]);
                        break;
                    case "-nutrientslist":
                        eating.PrintOutEatenNutrients();
                        break;
                    default:
                        continue;
                }
            }

        }

        private static void PrintOutNutition(List<FoodNutritionModel> FoodList)
        {
            foreach (var product in FoodList)
            {
                var typeObj = product.GetType();
                PropertyInfo[] pl = typeObj.GetProperties();
                foreach (var p in pl)
                {
                    Console.WriteLine($"{p.Name} = {p.GetValue(product)}");
                }
                Console.WriteLine();
            }
        }
    }
}
