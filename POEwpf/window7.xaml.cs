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
    /// Interaction logic for window7.xaml
    /// </summary>
    public partial class window7 : Window
    {
        private window2 panel2;
        public window7(window2 panel2)
        {
            InitializeComponent();
            this.panel2 = panel2;
        }

        private void btnScale_Click(object sender, RoutedEventArgs e)
        {
            window4 panel4 = new window4(panel2);
            window3 panel3 = new window3(panel2);
            this.Hide();
            panel2.txtRecipeName.Text = panel3.txtRecipeName2.Text;
            panel4.Show();
        }

        private void btnDisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            window3 panel3 = new window3(panel2);
            this.Hide();
            panel3.Show();

            panel3.lbRecipeDisplay2.Content = panel2.recentRecipe.PrintRecipe();
            panel3.txtRecipeName2.Text = panel2.recentRecipe.RecipeName;
        }

        private void btnChooseRecipe_Click(object sender, RoutedEventArgs e)
        {
            window5 panel5 = new window5(panel2);
            this.Hide();
            panel5.Show();
        }

        private void btnFilterRecipe_Click(object sender, RoutedEventArgs e)
        {
            window6 panel6 = new window6(panel2);
            this.Hide();
            panel6.Show();
        }

        private void btnBackToAddRecipe2_Click(object sender, RoutedEventArgs e)
        {
            window2 panel2 = new window2();
            this.Hide();
            panel2.Show();
        }
    }
}
