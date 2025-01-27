using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kaik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement el in Main.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC")
                textLabel.Text = "";
            else 
                if(str == "=")
            {
                string Value = new DataTable().Compute(textLabel.Text, null).ToString();
                textLabel.Text = Value;
            }
            else
                textLabel.Text += str;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
            b5.Visibility = Visibility.Visible;
            b6.Visibility = Visibility.Visible;
            b7.Visibility = Visibility.Visible;
            b8.Visibility = Visibility.Visible;
            b9.Visibility = Visibility.Visible;
            b10.Visibility = Visibility.Visible;
            b11.Visibility = Visibility.Visible;
            b12.Visibility = Visibility.Visible;
            b13.Visibility = Visibility.Visible;
            b14.Visibility = Visibility.Visible;
            b15.Visibility = Visibility.Visible; 
            b16.Visibility = Visibility.Visible;
            button_enter.Visibility = Visibility.Hidden;
            textLabel2.Visibility = Visibility.Hidden;
            textLabel3.Visibility = Visibility.Hidden;
            textLabel5.Visibility = Visibility.Hidden;
            textLabel.Text = "";
            text1.Text = Console.ReadLine();
            text2.Text = Console.ReadLine();
            text1.Visibility = Visibility.Hidden;
            text2.Visibility = Visibility.Hidden;
            button_enter.Content = "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
  
        }
    }
}