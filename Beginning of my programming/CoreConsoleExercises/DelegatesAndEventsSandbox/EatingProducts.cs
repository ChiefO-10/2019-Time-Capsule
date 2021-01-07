using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace DelegatesAndEventsSandbox
{
    class EatingProducts
    {
        public EventHandler AddingProduct;
        public EventHandler<string> AddedProduct;
        public Dictionary<string, double> ListOfEaten = new Dictionary<string, double>();

        public void AddProductEaten(string name, double ammount)
        {
            OnAddingProduct();
            if (FoodData.ContainsKey(name) && ammount>0)
            {
                var product = FoodData[$"{name}"];
                if (ListOfEaten.ContainsKey($"{name}"))
                    ListOfEaten[$"{name}"] += ammount;
                else ListOfEaten.Add(name, ammount);
                OnAddedProduct(name);
            }
            else
            {
                Console.WriteLine($"Adding {name} failed");
            }
        }

        public void PrintOutEatenList()
        {
            int i=1;
            foreach (var p in ListOfEaten)
            {
                Console.WriteLine($"{i}.{p.Key} -- {p.Value}g");
                i++;
            }
        }

        public void PrintOutEatenNutrients ()
        {
            int i = 1;
            foreach (var p in ListOfEaten)
            {
                var foodInfo = FoodData[$"{p.Key}"];
                var calories = foodInfo.Calories * p.Value/100;
                var protein = foodInfo.ProteinContent * p.Value/100;
                var fat = foodInfo.FatContent * p.Value/100;
                var carbohydrates = foodInfo.CarbohydratesContent * p.Value/100;

                Console.WriteLine($"{i}.{p.Key} -- {p.Value:F2}g -- protein {protein:F2}g -- fat {fat:F2}g -- carbs {carbohydrates:F2}g");
                i++;
            }
        }

        public void PrintOutEatenNutrients(string name)
        {
            var foodInfo = FoodData[$"{name}"];
            var calories = foodInfo.Calories;
            var protein = foodInfo.ProteinContent;
            var fat = foodInfo.FatContent;
            var carbohydrates = foodInfo.CarbohydratesContent;

            Console.WriteLine($"{name} -- 100g -- protein {protein:F2}g -- fat {fat:F2}g -- carbs {carbohydrates:F2}g");
        }

        protected virtual void OnAddedProduct(string prod)
        {
            AddedProduct?.Invoke(this, prod);
        }

        protected virtual void OnAddingProduct()
        {
            AddingProduct?.Invoke(this, EventArgs.Empty);
        }

        private Dictionary<string,FoodNutritionModel> FoodData = new Dictionary<string,FoodNutritionModel>
        {
            {"egg", new FoodNutritionModel {Name="egg", Calories = 30D, CarbohydratesContent= 0D, FatContent = 0D, ProteinContent = 8D} },
            {"milk",new FoodNutritionModel {Name="milk", Calories = 149D, CarbohydratesContent= 12.3D, FatContent = 8D, ProteinContent = 7.7D} },
            {"flour",new FoodNutritionModel {Name="flour", Calories = 340D, CarbohydratesContent= 72D, FatContent = 2.5D, ProteinContent = 13.2D} },
            {"bread",new FoodNutritionModel {Name="bread", Calories = 264D, CarbohydratesContent= 49D, FatContent = 3.2D, ProteinContent = 9D} }
        };

    }
}
