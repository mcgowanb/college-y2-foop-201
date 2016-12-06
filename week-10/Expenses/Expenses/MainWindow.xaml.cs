using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Expenses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Expense> expenses;
        decimal total;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            expenses = new List<Expense>();
            total = 0;
            for(int i = 0; i < 5; i++)
            {
                Expense exp = new Expense();
                expenses.Add(exp);
                total += exp.Cost;
            }
            lbxExpenses.ItemsSource = expenses;
            lblTotal.Content = total.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
