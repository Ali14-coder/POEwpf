using System;
using System.Collections.Generic;
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

        private window2 panel2;
        public window6(window2 panel2)
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
                                                                   //   FilteredRecipesList = new SortedList<string, Recipes>();

            InitializeComponent();

            SortedRecipesList = panel2.GetSortedRecipesList(); //retrieves the sortedRecipesList from window2
            

            this.panel2 = panel2;
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
    }
}
