using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEwpf
{
    public class Ingredients
    {
        public string IngredientName { get; set; }
        public double OldQuantity { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasurement { get; set; }
        public string FoodGroup { get; set; }
        public double Calories { get; set; }
        public string RecipeName { get; set; }

        public Ingredients(string ingredientName, double quantity, string unitOfMeasurement, string foodGroup, double calories, string recipeName)//assigning constructirs
        {
            IngredientName = ingredientName;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            OldQuantity = quantity;

            FoodGroup = foodGroup;
            Calories = calories;

            RecipeName = recipeName;
        }

        public void QuantityScale(double scaleFactor) // this method calculates the new quantity
        {
            Quantity = OldQuantity * scaleFactor;
        }

        public void ResetQuantity()
        {
            Quantity = OldQuantity;
        }

        public void CalorieScale(double scaleFactor)
        {
            Calories = Calories * scaleFactor;
        }
    }
}
