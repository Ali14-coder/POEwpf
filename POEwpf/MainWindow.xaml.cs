using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POEwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)

        public MainWindow()
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
            InitializeComponent();
            HardCodedRecipes();
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {   window2 panel2 = new window2();
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }
    }
}