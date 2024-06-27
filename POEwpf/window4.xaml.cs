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
    /// Interaction logic for window4.xaml
    /// </summary>
    public partial class window4 : Window
    {
        public Recipes recipes;
        public Recipes recentRecipe;
        //public Steps steps;
        //public Ingredients ingredients;

        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)
        public List<Ingredients> IngredientsList;
        public List<Steps> StepsList;

        private window2 panel2;
        public window4(window2 Panel2)
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
                                                                   //   FilteredRecipesList = new SortedList<string, Recipes>();

            InitializeComponent();
            panel2 = Panel2;
        }

        private void btnBackToViewRecipe2_Click(object sender, RoutedEventArgs e)
        {
            window3 panel3 = new window3(panel2);
            this.Hide();
            panel3.lbDisplayIngreAndSteps.Content = recentRecipe.PrintRecipe();
            panel3.txtRecipeName2.Text = recentRecipe.RecipeName;
            panel3.Show();
        }

        private void btnHalf_Click(object sender, RoutedEventArgs e)
        {
                window3 panel3 = new window3(panel2);

                double scaleFactor = 0.5;
                Recipes recentRecipe = panel2.GetRecentRecipe();

            if (recentRecipe != null)
            {
                recentRecipe.ScalingTheRecipe(scaleFactor);
                panel3.lbDisplayIngreAndSteps.Content = recentRecipe.PrintRecipe();

                this.Hide();
                panel3.Show();

                MessageBox.Show("Quantities successfully halved");
            }
            else
            {
                MessageBox.Show("Error. Recipe is null");
            }
        }

        private void btnDouble_Click(object sender, RoutedEventArgs e)
        {
           
                window3 panel3 = new window3(panel2);

                double scaleFactor = 2;
                Recipes recentRecipe = panel2.GetRecentRecipe();

            if (recentRecipe != null)
            {
                recentRecipe.ScalingTheRecipe(scaleFactor);
                panel3.lbDisplayIngreAndSteps.Content = recentRecipe.PrintRecipe();

                this.Hide();
                panel3.Show();

                MessageBox.Show("Quantities successfully doubled");
            }
            else
            {
                MessageBox.Show("Error. Recipe is null");
            }
        }

        private void btnTriple_Click(object sender, RoutedEventArgs e)
        {
                window3 panel3 = new window3(panel2);

                double scaleFactor = 3;
                Recipes recentRecipe = panel2.GetRecentRecipe();

                if (recentRecipe != null)
                {
                recentRecipe.ScalingTheRecipe(scaleFactor);
                panel3.lbDisplayIngreAndSteps.Content = recentRecipe.PrintRecipe();

                this.Hide();
                panel3.Show();

                MessageBox.Show("Quantities successfully tripled");
            }
            else
            {
                MessageBox.Show("Error. Recipe is null");
            }
        }


        private void btnResetRecipe_Click(object sender, RoutedEventArgs e)
        {
           
                window3 panel3 = new window3(panel2);

                Recipes recentRecipe = panel2.GetRecentRecipe();

            if (recentRecipe != null)
            {
                panel2.recentRecipe.ResetRecipe();
                panel3.lbDisplayIngreAndSteps.Content = panel2.recentRecipe.PrintRecipe();

                this.Hide();
                panel3.Show();

                MessageBox.Show("Quantities successfully reset");
            }
            else
            {
                MessageBox.Show("Error. Recipe is null");
            }
        }
    }
}
