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

namespace W5IntroToWpf
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

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            //var result = MessageBox.Show("Hello world", "Message", MessageBoxButton.YesNo, MessageBoxImage.Information);

            //if (result == MessageBoxResult.Yes)
            //    MessageBox.Show("YES clicked");
            //else
            //    MessageBox.Show("NO clicked");


            string name = txtFirstName.Text;
            MessageBox.Show("Hello " + name);
        }

        private void txtFirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.Background = Brushes.LightBlue;
        }

        private void txtFirstName_LostFocus(object sender, RoutedEventArgs e)
        {
            txtFirstName.Background = Brushes.White;
        }
    }
}