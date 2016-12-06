using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        ObservableCollection<Expense> expenses;
        decimal total;
        private static Random randomFactory = new Random();
        private String[] types = { "Travel", "Entertainment", "Office" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            Expense exp = new Expense();
            exp.Cost = GetRandomCost();
            exp.Date = GetRandomDate();
            exp.Type = GetRandomType();
            expenses.Add(exp);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GenerateRandomExpenses();

        }

        public void GenerateRandomExpenses()
        {

            expenses = new ObservableCollection<Expense>();
            total = 0;
            for (int i = 0; i < 5; i++)
            {
                Expense exp = new Expense();
                exp.Cost = GetRandomCost();
                exp.Date = GetRandomDate();
                exp.Type = GetRandomType();
                expenses.Add(exp);
                total += exp.Cost;
            }
            lbxExpenses.ItemsSource = expenses;
            lblTotal.Content = total.ToString("C", CultureInfo.CurrentCulture);
        }

        private decimal GetRandomCost()
        {
            decimal cost = (randomFactory.Next(10001) / 100);
            return cost;
        }

        private String GetRandomType()
        {
            int rnd = randomFactory.Next(0, 2);
            return types[rnd];
        }

        private String GetRandomDate()
        {
            DateTime d = DateTime.Today.AddDays(randomFactory.Next(0, 31));
            return d.ToShortDateString();
        }
    }
}
