using POEwpf;
using System;
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
    /// Interaction logic for window6.xaml
    /// </summary>
    public partial class window6 : Window
    {
        public Recipes recipes;
        public Recipes recentRecipe;
        public Steps steps;
        public Ingredients ingredients;

        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)
        public List<Ingredients> IngredientsList;
        public List<Steps> StepsList;

        ObservableCollection<Recipes> FilteredRecipesList; //(jwmsft, 2024)

        private window2 panel2;
        public window6(window2 panel2)
        {
            InitializeComponent();
            this.panel2 = panel2;

            SortedRecipesList = panel2.GetSortedRecipesList(); //retrieves the sortedRecipesList from window2
            FilteredRecipesList = new ObservableCollection<Recipes>(SortedRecipesList.Values);
            FilteredItemsControl.ItemsSource = SortedRecipesList;

            
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }

        private void btnIngreFilter_Click(object sender, RoutedEventArgs e)
        {
            lbFilterOoptionLabel.Content = "Enter key ingredient:"; 
        }

        private void btnFoodGroupFilter_Click(object sender, RoutedEventArgs e)
        {
            lbFilterOoptionLabel.Content = "Select food group:";
        }

        private void btnCalorieFilter_Click(object sender, RoutedEventArgs e)
        {
            lbFilterOoptionLabel.Content = "Enter maximum calories:";
        }

        private void FilterApplication()
        {
            var filterer = SortedRecipesList.Values.Where(recipe => Filtering(ingredients, recipe));
            FilterOutNonMatches(filterer);
            RepopulateFilteredRecipes(filterer);
        }
        private bool Filtering(Ingredients ingredients, Recipes recipe)
        {
            bool ingredientMatch = string.IsNullOrEmpty(tbFilterByTextIngre.Text) || recipe.IngredientsList.Any(ingredient => ingredient.Contains(tbFilterByTextIngre.Text, StringComparison.InvariantCultureIgnoreCase));

            bool foodGroupMatch = string.IsNullOrEmpty(cbFoodGroup.Text) || ingredients.FoodGroup.Contains(cbFoodGroup.Text, StringComparison.InvariantCultureIgnoreCase);

            bool maxCalorieMatch = string.IsNullOrEmpty(tbFilterByTextCalories.Text) || ingredients.Calories <= int.Parse(tbFilterByTextCalories.Text);

            return ingredientMatch && foodGroupMatch && maxCalorieMatch;
        }

        private void FilterOutNonMatches(IEnumerable<Recipes> recipeFilter) //method to remove any recipes that do not match the user's input
        {
            for (int i = FilteredRecipesList.Count; i > 0; i--)
            {
                var item = FilteredRecipesList[i];
                if (!recipeFilter.Contains(item))
                {
                    FilteredRecipesList.Remove(item); 
                }
            }
        }

        private void RepopulateFilteredRecipes(IEnumerable<Recipes> recipeFilter)
        {
            foreach (var item in recipeFilter)
            {
                if (!FilteredRecipesList.Contains(item)) //if statement determining whether a recipe that is within the recipeFilter, but is not in the FilteredRecipeList
                {
                    FilteredRecipesList.Add(item); //If exact match is not within the FilteredRecipeList, then it must be added
                }
            }
        }
    }
}
//References:
//jwmsft(2024).Filtering collections - Windows apps. [online] Microsoft.com.Available at: https://learn.microsoft.com/en-us/windows/apps/design/controls/listview-filtering [Accessed 27 Jun. 2024].
