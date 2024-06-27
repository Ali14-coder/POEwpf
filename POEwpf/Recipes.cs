using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEwpf
{
    public delegate void CaloriesExceededWarning(string recipeName, double totalCalories); //declaring the delegate
    public class Recipes
    {
        public List<Ingredients> IngredientsList { get; set; }
        public List<Steps> StepsList { get; set; }

        public string RecipeName { get; set; }
        public bool IsScaled { get; set; } = false;

        public event CaloriesExceededWarning ExceededCalories; // the 'public event' allows this delegate to notify ohter classes when the calories have been exceeded
        public Recipes(string recipeName)
        {
            IngredientsList = new List<Ingredients>(); //assigning variables to ingrediet list
            StepsList = new List<Steps>(); //assigning variables to step list

            RecipeName = recipeName; //assigning contructor variable to RecipeName

        }

        internal void AddIngredient(Ingredients ingredient) //populating the IngredientsList by adding an ingredient
        {
            IngredientsList.Add(ingredient);
            CalorieCheck();
        }

        internal void AddStep(Steps step) //populating the StepsList by adding a step
        {
            StepsList.Add(step);
        }

        public void ScalingTheRecipe(double scaleFactor)//this method loops through each ingredient in the IngredientsList and scales the quantity by the scaleFactor
        {
            IsScaled = true;
            foreach (var ingredient in IngredientsList)
            {
                ingredient.QuantityScale(scaleFactor);
                ingredient.CalorieScale(scaleFactor);
            }
        }

        public void ResetRecipe()
        {
            IsScaled = false;
            foreach (var ingredient in IngredientsList)
            {
                ingredient.ResetQuantity();
                ingredient.ResetCalories();
            }
        }

        public string PrintRecipe()
        {

            string displayRecipe = "Ingredients:\n*********************\n";
            if (!IsScaled)
            {
                foreach (var ingredient in IngredientsList)
                {
                    displayRecipe += ingredient.OldQuantity + ingredient.UnitOfMeasurement + " of " + ingredient.IngredientName + "\n";
                }
            }
            else
            {
                foreach (var ingredient in IngredientsList)
                {
                    displayRecipe += ingredient.Quantity + "  " + ingredient.UnitOfMeasurement + " of " + ingredient.IngredientName + "\n";
                }
            }

            displayRecipe += "\nSteps:\n*********************\n";
            for (int i = 0; i < StepsList.Count; i++)
            {
                displayRecipe += "Step " + (i + 1) + "\t " + StepsList[i].StepDescription + "\n";
            }

            displayRecipe += "\nTotal calories: " + totalCalorieCalculation() + "kcal\n";

            return displayRecipe;
        }

        public double totalCalorieCalculation()
        {
            double totalCalories = 0.0;

            if (IngredientsList == null) //error handling in case there is nothing inside the ingredientsList
            {
                totalCalories = 0.0;
            }
            else
            {
                foreach (var ingredient in IngredientsList)
                {
                    totalCalories += ingredient.Calories;
                }

            }
            return totalCalories;
        }

        private void CalorieCheck()
        {
            double totalCalories = 0.0;
            foreach (var ingredient in IngredientsList) //searches through each calorie stored and adds it to the calorie total
            {
                totalCalories += ingredient.Calories;
            }
            if (totalCalories > 300) //checks whether the total calories exceed 300. 
            {
                ExceededCalories?.Invoke(RecipeName, totalCalories); //if totalCalories exceeds 300, the recipe name and the total calories of the recipe is pulled through
            }// (Vidya Vrat Agarwal, 2023)
        }

    }
}//Referencing:
//
//Vidya Vrat Agarwal (2023). Mastering Delegates and Events In C# .NET. [online] C-sharpcorner.com. Available at: https://www.c-sharpcorner.com/UploadFile/84c85b/delegates-and-events-C-Sharp-net/ [Accessed 30 May 2024].
//
//Duggal, N. (2021). Introduction to List in C#. [online] Simplilearn.com. Available at: https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/c-sharp-list [Accessed 30 May 2024].
