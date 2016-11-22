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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Factorial
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

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtNumber.Focus();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            decimal factorial = number;
            for (int i = 1; i < number; i++)
            {
                factorial = factorial * i;
            }
            txtFactorial.Text = factorial.ToString("0,00");
            txtNumber.Text = "";
            txtNumber.Focus();
        }
    }
}
