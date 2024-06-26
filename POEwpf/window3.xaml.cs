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
    /// Interaction logic for window3.xaml
    /// </summary>
    public partial class window3 : Window
    {
        public Recipes recipes;
        public Recipes recentRecipe;
        public Steps steps;
        public Ingredients ingredients;

        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)
        public List<Ingredients> IngredientsList;
        public List<Steps> StepsList;

        private window2 panel2;

        public window3(window2 Panel2)
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
                                                                   //   FilteredRecipesList = new SortedList<string, Recipes>();
            InitializeComponent();

            panel2 = Panel2;
        
        }
        private void btnBackToAddRecipe1_Click(object sender, RoutedEventArgs e)
        {
            window2 panel2 = new window2();

            this.Hide();
            panel2.Show();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lbDisplayIngreAndSteps.Content = ""; //MAKE INTO A LISTBOX
        }

        private void btnChooseRecipe_Click(object sender, RoutedEventArgs e)
        {
            window5 panel5 = new window5();
            this.Hide();
            panel5.Show();
            panel5.lbRecipeOptions.Items.Add(""); //makes listbox empty

            int index = 1;
            foreach (var recipeName in SortedRecipesList.Keys) //this is meant to show a number next to each recipeName called from the SortedList
            {
                panel5.lbRecipeOptions.Items.Add(index + ". " + recipeName);
                index++;
            }
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {
            window4 panel4 = new window4(panel2);
            this.Hide();
            panel4.Show();
        }

    }
}
