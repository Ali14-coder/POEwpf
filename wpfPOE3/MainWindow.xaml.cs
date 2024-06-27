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
     //   public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)

        public MainWindow()
        {
        //    SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
            InitializeComponent();
            
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {   window2 panel2 = new window2();
            window7 panel7 = new window7(panel2);
            this.Hide();
            panel7.Show();
        }
    }
}