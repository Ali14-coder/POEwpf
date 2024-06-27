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
    /// Interaction logic for window5.xaml
    /// </summary>
    public partial class window5 : Window
    {
        public Recipes recipes;
        public Recipes recentRecipe;
        public Steps steps;
        public Ingredients ingredients;

        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)
        public List<Ingredients> IngredientsList;
        public List<Steps> StepsList;

        private window2 panel2;
        public window5(window2 Panel2)
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
                                                                   //   FilteredRecipesList = new SortedList<string, Recipes>();
            InitializeComponent();
            panel2 = Panel2;

            SortedRecipesList = panel2.GetSortedRecipesList(); //retrieves the sortedRecipesList from window2

            lbRecipeOptions.Items.Add(""); //makes listbox empty

            int index = 1;
            foreach (var recipeName in SortedRecipesList.Keys) //this is meant to show a number next to each recipeName called from the SortedList
            {
                lbRecipeOptions.Items.Add(index + ". " + recipeName);
                index++;
            }
        }

        private void btnBackToViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            window4 panel4 = new window4(panel2);
            this.Hide();
            panel4.Show();
        }

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbRecipeOptions.SelectedIndex; //takes in the int of the up down scroll selection
            

            if (selectedIndex == -1) //error handeling to check whether index selection is within bounds
            {
                MessageBox.Show("Recipe number out of range. Please re-select");
                return;
            }
            if (lbRecipeOptions.SelectedItem ==null)
            {
                MessageBox.Show("No recipe chosen. Please select a recipe first");
            }

            string selectedItem = lbRecipeOptions.SelectedItem.ToString();
            string recipeName = selectedItem.Substring(selectedItem.IndexOf(". ") + 2);

            if(SortedRecipesList.ContainsKey(recipeName))
            {
                Recipes selectedRecipe = SortedRecipesList[recipeName]; //this variable stores the recipe name by extracting the everything after the ". " and executes this when the recipe name is selected
                lbDisplaySelectedRecipe.Content = "Recipe:" + selectedRecipe.RecipeName + "\n";
                lbDisplaySelectedRecipe.Content += selectedRecipe.PrintRecipe();
            }
        }

        private void btnExit5_Click(object sender, RoutedEventArgs e)
        {
            MainWindow panel1 = new MainWindow();
            this.Hide();
            panel1.Show();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }
    }
}
