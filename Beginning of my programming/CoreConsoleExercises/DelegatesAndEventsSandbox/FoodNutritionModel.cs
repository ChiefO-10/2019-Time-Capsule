using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesAndEventsSandbox
{
    /// <summary>
    /// Food Nutrition Table per 100g
    /// </summary>
    class FoodNutritionModel
    {
        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// kCal amount per 100g
        /// </summary>
        public double Calories { get; set; }
        /// <summary>
        /// Protein amount per 100g
        /// </summary>
        public double ProteinContent { get; set; }
        /// <summary>
        /// Carbs amount per 100g
        /// </summary>
        public double CarbohydratesContent { get; set; }
        /// <summary>
        /// Fat amount per 100g
        /// </summary>
        public double FatContent { get; set; }

    }
}
