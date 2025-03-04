﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POEwpf
{
    /// <summary>
    /// Interaction logic for window2.xaml
    /// </summary>
    public partial class window2 : Window
    {
        public Recipes recipes;
        public Recipes recentRecipe;
        public Steps steps;
        public Ingredients ingredients;

        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)
        public List<Ingredients> IngredientsList;
        public List<Steps> StepsList;

        public window2()
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
            InitializeComponent();
            HardCodedRecipes();

        }

        private void btnSetRecipe_Click(object sender, RoutedEventArgs e)
        {
            recentRecipe = new Recipes(txtRecipeName.Text); //assigns the recipe entered into the 'recentRecipe'
        }
        public Recipes GetRecentRecipe() //returns recentRecipe to be used throughout program
        {
            return recentRecipe;
        }

        private void btnClearIngre_Click(object sender, RoutedEventArgs e)
        {
            txtIngreName.Text = "";
            txtUnitOfMesaure.Text = "";
            cbFoodGroup.Text = string.Empty;
            UpDownQuantity.Text = "";
            UpDownCalories.Text = "";
        }

        private void btnAddIngre_Click(object sender, RoutedEventArgs e)
        {

            string ingredientName = txtIngreName.Text;
            double quantity = Convert.ToDouble(UpDownQuantity.Text);
            string unitOfMeasurement = txtUnitOfMesaure.Text;
            string foodGroup = cbFoodGroup.Text;
            double calories = Convert.ToDouble(UpDownCalories.Text);
            string recipeName = txtRecipeName.Text;

            if (string.IsNullOrWhiteSpace(recipeName) || string.IsNullOrWhiteSpace(ingredientName) || string.IsNullOrWhiteSpace(unitOfMeasurement) || string.IsNullOrWhiteSpace(foodGroup) || quantity == 0.0 || calories == 0.0)
            {
                MessageBox.Show("You left a field blank. Please enter all fields."); //error handeling to check for empty fields
            }
            else
            {
                Ingredients ingredient = new Ingredients(ingredientName, quantity, unitOfMeasurement, foodGroup, calories, recipeName); //initializing the Ingredient class and calling the constructor method with corresponding parameters
                recentRecipe.AddIngredient(ingredient);
                recentRecipe.ExceededCalories += OnExceededCalories;

                MessageBox.Show("Ingredient successfully added");

            }
        }
        public List<Ingredients> GetIngredientsList()
        {
            return IngredientsList;
        }
        private void OnExceededCalories(string recipeName, double totalCalories)//(Vidya Vrat Agarwal, 2023)
        {
            MessageBox.Show("Recipe exceeds the 300kcal limit!\n" + recipeName + "' contains " + totalCalories + "kcal.", "CALORIE WARNING", MessageBoxButton.OK);
        }

        private void btnAddStep_Click(object sender, RoutedEventArgs e)
        {
            string stepDescription = txtStepDescription.Text;
            if (string.IsNullOrWhiteSpace(stepDescription)) //error handeling to check for empty fields
            {
                MessageBox.Show("You left a field blank. Please enter all fields.");
            }
            else
            {
                Steps step = new Steps(stepDescription); //initializing variable 'step' to class "Step" taking in the string 'stepDescription'

                recentRecipe.AddStep(step);
                MessageBox.Show("Step successfully added");
            }
        }

        private void btnClearStep_Click(object sender, RoutedEventArgs e)
        {
            txtStepDescription.Text = "";
        }
        public void HardCodedRecipes()
        {
            var recipe1 = new Recipes("Bread");
            recipe1.IngredientsList.Add(new Ingredients("Flour", 500, "grams", "Carbs & Grains", 50, "Bread"));
            recipe1.IngredientsList.Add(new Ingredients("Sugar", 200, "grams", "Sugar", 90, "Bread"));
            recipe1.IngredientsList.Add(new Ingredients("Yeast", 0.25, "tbs", "Carbs & Grains", 10, "Bread"));

            recipe1.StepsList.Add(new Steps("Sift flour into bowl."));
            recipe1.StepsList.Add(new Steps("Slowly add sugar."));
            recipe1.StepsList.Add(new Steps("Mix the yeast into the mixture."));

            var recipe2 = new Recipes("Cookies");
            recipe2.IngredientsList.Add(new Ingredients("All purpose flour", 555, "grams", "Carbs & Grains", 65, "Cookies"));
            recipe2.IngredientsList.Add(new Ingredients("Chocolate chips", 1, "cup", "Sugar", 230, "Cookies"));

            recipe2.StepsList.Add(new Steps("Sift flour carefully into bowl."));
            recipe2.StepsList.Add(new Steps("Pour the chocolate chips into the mixture."));
            recipe2.StepsList.Add(new Steps("Mix together."));

            SortedRecipesList.Add(recipe1.RecipeName, recipe1);
            SortedRecipesList.Add(recipe2.RecipeName, recipe2);
        }
        private void btnAddRecipe_Click(object sender, RoutedEventArgs e)
        {

            SortedRecipesList.Add(recentRecipe.RecipeName, recentRecipe); //adds the recipe name (string) and the recipe
            

            MessageBox.Show("Recipe successfully added");
        }

        private void btnDisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            window3 panel3 = new window3(panel2);
            this.Hide();
            panel3.Show();

            panel3.lbRecipeDisplay2.Content= recentRecipe.PrintRecipe();
            panel3.txtRecipeName2.Text = recentRecipe.RecipeName;
        }

        public SortedList<string, Recipes> GetSortedRecipesList()
        {
            return SortedRecipesList;
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }
    }
}
