using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ShoppingCart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> products;
        private ObservableCollection<Product> cart;
        private decimal totalCost;
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
            products = new ObservableCollection<Product>();
            cart = new ObservableCollection<Product>();

            Product p1 = new Product("1324", "Book", 12.53m);
            products.Add(p1);
            Product p2 = new Product("1325", "Bike", 780m);
            products.Add(p2);
            Product p3 = new Product("1326", "Boat", 900m);
            products.Add(p3);

            lbxProducts.ItemsSource = products;
            lbxCart.ItemsSource = cart;
            UpdateTotalCost();

            String[] bikeTypes = { "All", "Male", "Female" };
            cbxBikeType.ItemsSource = bikeTypes;
            cbxBikeType.SelectedIndex = 0;

        }

        private void btnAddTax_Click(object sender, RoutedEventArgs e)
        {
            lbxProducts.ItemsSource = null;
            foreach (var item in products)
            {
                item.AddTax();
            }
            lbxProducts.ItemsSource = products;
        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = lbxProducts.SelectedItem as Product;

            if (selectedProduct != null)
            {
                cart.Add(selectedProduct);
                products.Remove(selectedProduct);
                UpdateTotalCost();
            }
        }

        private void btnRemoveFromCart_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = lbxCart.SelectedItem as Product;
            if (selectedProduct != null)
            {
                cart.Remove(selectedProduct);
                products.Add(selectedProduct);
                UpdateTotalCost();
            }
        }

        private void UpdateTotalCost()
        {
            totalCost = 0;
            foreach (var item in cart)
            {
                totalCost += item.Price;
            }
            lblTotalCost.Content = totalCost.ToString("C");
        }
    }
}
