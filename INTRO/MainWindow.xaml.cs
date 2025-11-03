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

namespace INTRO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick_HelloWorld(object sender, RoutedEventArgs e)
        {
            // statements have to be closed with ;
            // MessageBox.Show("Hello World");

            if (hejknapp.Content == "hej!")
            {
                hejknapp.Content = "tack!!";
            } 
            else
            {
                hejknapp.Content = "hej!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (numberOfPirates.Background != Brushes.Goldenrod)
            {
                numberOfPirates.Background = Brushes.Goldenrod;
            }
            else
            {
                numberOfPirates.Background = Brushes.Honeydew;
            }
        }
    }
}