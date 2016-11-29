using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
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
        private ObservableCollection<Product> filteredList;
        private decimal totalCost;
        private enum BikeTypes { All, Male, Female };


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
            filteredList = new ObservableCollection<Product>();

            Variation male = new Variation(BikeTypes.Male.ToString());
            Variation female = new Variation(BikeTypes.Female.ToString());


            Product p1 = new Product("1324", "Bike", 12.53m, male);
            products.Add(p1);
            Product p2 = new Product("1325", "Mountain Bike", 780m, female);
            products.Add(p2);
            Product p3 = new Product("1326", "Mountain Bike", 900m, male);
            products.Add(p3);
            Product p4 = new Product("1432", "Bike", 123.53m, female);
            products.Add(p4);
            Product p5 = new Product("1122", "Road Bike", 999.99m, female);
            products.Add(p5);
            Product p6 = new Product("1123", "Road Bike", 829.99m, female);
            products.Add(p6);

            lbxProducts.ItemsSource = products;
            lbxCart.ItemsSource = cart;
            UpdateTotalCost();

            String[] bikeTypes = { "All", "Male", "Female" };

            cbxBikeType.ItemsSource = bikeTypes;
            cbxBikeType.SelectedIndex = 0;
        }

       

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = lbxProducts.SelectedItem as Product;

            if (selectedProduct != null)
            {
                cart.Add(selectedProduct);
                products.Remove(selectedProduct);
                filteredList.Remove(selectedProduct);
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
                totalCost += item.getTotalCost();
            }
            lblTotalCost.Content = totalCost.ToString("C");
        }

        private void cbxBikeType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selected = cbxBikeType.SelectedItem as String;
            lbxProducts.ItemsSource = "";
            filteredList.Clear();

            if (selected.Equals("All"))
            {
                lbxProducts.ItemsSource = products;
            }
            else
            {
                foreach (var item in products)
                {
                    if (item.Type.Equals(selected))
                    {
                        filteredList.Add(item);
                    }
                }
                lbxProducts.ItemsSource = filteredList;
            }

        }

        private void btnEstimateShipping_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            DateTime d = DateTime.Now.AddDays(rnd.Next(1, 30));

            lblShippingDate.Content = d.ToString("d", CultureInfo.CurrentCulture);
        }
    }
}
