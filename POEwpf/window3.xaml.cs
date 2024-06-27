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

        private window2 panel2;

        public window3(window2 Panel2)
        {
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
            lbRecipeDisplay2.Content = ""; //MAKE INTO A LISTBOX
        }

        //private void btnScale_Click(object sender, RoutedEventArgs e)
        //{
        //    window4 panel4 = new window4(panel2);
        //    this.Hide();
        //    panel4.Show();
        //}

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }
    }
}
