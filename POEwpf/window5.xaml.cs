using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

        private window2 panel2; //(Zingo, 2024)
        public window5(window2 Panel2) //(Zingo, 2024)
        {
            InitializeComponent();
            panel2 = Panel2; //(Zingo, 2024)

            // PopulateRecipeListBox();
            SortedRecipesList = panel2.GetSortedRecipesList(); //retrieves the sortedRecipesList from window2

            if (SortedRecipesList == null)
            {
                MessageBox.Show("SortedRecipesList is empty.");
                return;
            }
            foreach (var recipeName in SortedRecipesList.Keys)
            {
                lbRecipeOptions.Items.Add(recipeName);
            }
        }
       
        //private void PopulateRecipeListBox()
        //{
        //    SortedRecipesList = panel2.GetSortedRecipesList(); //retrieves the sortedRecipesList from window2

        //    lbRecipeOptions.Items.Add(""); //makes listbox empty

        //    int index = 1;
        //    foreach (var recipeName in SortedRecipesList.Keys) //this is meant to show a number next to each recipeName called from the SortedList
        //    {
        //        lbRecipeOptions.Items.Add(index + ". " + recipeName);
        //        index++;
        //    }
        //}

        private void btnViewRecipe_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbRecipeOptions.SelectedIndex; //this is an indicator for the selected index  

            if (selectedIndex == -1) //if statment determing if selection was out of range
            {
                MessageBox.Show("Recipe number out of range. Please re-select");
                return;
            }

            string recipeName = lbRecipeOptions.SelectedItem.ToString(); //converts to string

            if (SortedRecipesList.ContainsKey(recipeName))//obtains the recipeName from sortedlist
            {
                Recipes selectedRecipe = SortedRecipesList[recipeName];
                lbDisplaySelectedRecipe.Content = "Recipe: " + selectedRecipe.RecipeName + "\n";
                lbDisplaySelectedRecipe.Content += selectedRecipe.PrintRecipe();
            }
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }
    }
}
//Refereces:
//Zingo (2024). Initializing a WPF-window with an optional parameter. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/26246293/initializing-a-wpf-window-with-an-optional-parameter [Accessed 27 Jun. 2024].
